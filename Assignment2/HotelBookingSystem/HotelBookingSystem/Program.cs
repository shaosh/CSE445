//Final version

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections;
using HotelBookingSystem.CryptService;

namespace HotelBookingSystem
{
    public delegate void priceCutEvent(double price, double previousPrice, int counter);
    public delegate void orderCompletedEvent(OrderClass orderObj, Double amountOfCharge);

    class Clock
    {
        private static Int32 hour;
        public Clock()
        {
            hour = 0;
        }
        public void start()
        {
            while (true)
            {
                System.Threading.Thread.Sleep(1000);
                if (hour == 23)
                    hour = 0;
                else
                    hour++;
                //             Console.WriteLine(hour);
            }
        }
        public static Int32 getHour()
        {
            return hour;
        }
    }

    public class pricecutLock {
        public static Object obj = new Object();
        public static AutoResetEvent Event = new AutoResetEvent(false);
    }

    public class HotelSupplier
    {
        public static event priceCutEvent priceCut;
        public static event orderCompletedEvent orderCompleted;

        private DateTime startTime;
        private DateTime finishTime;
        private static ArrayList roomPriceList;
        private static ArrayList creditCardNumberList;
        private static DoubleValue roomPrice = new DoubleValue();
        public static Int32 counter;
        private double taxRate = 0.1;
        private double locationCharge = 25;

        public HotelSupplier()
        {
            counter = 0;
            roomPrice.previousPrice = 100;
            roomPrice.price = 100;
            roomPriceList = new ArrayList();
            creditCardNumberList = new ArrayList();
        }

        public static void changePrice(double price)
        {
            roomPrice.previousPrice = roomPrice.price;
            roomPrice.price = price;
            if (price < roomPrice.previousPrice)
            {
                if (priceCut != null)
                {
                    priceCut(roomPrice.price, roomPrice.previousPrice, counter);
                    pricecutLock.Event.WaitOne();                    
                }
                counter++;
            } 
        }

        public void PricingModel()
        {
            Clock clock = new Clock();
            Thread clockThread = new Thread(new ThreadStart(clock.start));
            clockThread.Start();
            Int32 time;

            int orderIndex = 0;
            startTime = DateTime.Now;
            while (counter < 10)
            {
                Thread.Sleep(1000);
                time = Clock.getHour();
                double price = roomPrice.price * (1 + Math.Sin(time) / 4.0); 
                changePrice(price);
                orderIndex++;
            }
            finishTime = DateTime.Now;
            Console.WriteLine("        The Total Time Used by HotelSupplier Thread: {0}.", finishTime - startTime);
        }

        public void orderProcessing()
        {
           
            String orderString;
            while (true)
            {
                orderString = Program.mcb.getOneCell();
                OrderClass orderObj = Coder.decoder(orderString);
                Monitor.Enter(roomPrice);
                if (HotelSupplier.checkCreditCardNumber(orderObj.getCardNo()))
                {
                    double amountOfCharge = orderObj.getUnitPrice() * orderObj.getAmt() + taxRate * orderObj.getUnitPrice() * orderObj.getAmt() + locationCharge;
                    orderObj.setReceiveTime(DateTime.Now);
                    if (orderCompleted != null)
                        orderCompleted(orderObj, amountOfCharge);
                }
                Monitor.Exit(roomPrice);
              
            }
        }

        public static double getPrice()
        {
            return roomPrice.price;
        }

        public static double getPreviousPrice()
        {
            return roomPrice.previousPrice;
        }

        public void registerCreditCardNumber(Int32 agencyId)
        {
            Int32 creditCardNumber = 7000 + agencyId;
            creditCardNumberList.Add(creditCardNumber);
        }

        public static Boolean checkCreditCardNumber(Int32 creditCardNumber)
        {
            if (creditCardNumberList.Contains(creditCardNumber))
                return true;
            else
                return false;
        }

        public static Int32 getCreditCardNumber(Int32 agencyId)
        {
            if (creditCardNumberList.Contains(7000 + agencyId))
                return 7000 + agencyId;
            else
                return 0;
        }
    }

    public class TravelAgency
    {
        public static HotelSupplier hotel = new HotelSupplier();        
        
        public static int pricecutLockCounter = 0;
        
        int amountOfRoom;
        int[] orderIdsOfAgency = new int[10];
        public static DoubleValue roomPrice = new DoubleValue();
        public static AutoResetEvent[] Event = new AutoResetEvent[10];

        public void agencyFunc()
        {
            Int32 currentThreadName = Convert.ToInt32(Thread.CurrentThread.Name);
            hotel.registerCreditCardNumber(currentThreadName);
            Event[currentThreadName] = new AutoResetEvent(false);

            while (true)
            {
                int eventIndex;
                Int32 threadName, _orderIds;
                int.TryParse(Thread.CurrentThread.Name, out eventIndex);
                Event[eventIndex].WaitOne();
                OrderClass orderObj = new OrderClass();

                amountOfRoom = calculateRoomAmount();
                threadName = Convert.ToInt32(Thread.CurrentThread.Name);
                _orderIds = ++orderIdsOfAgency[threadName];
                orderObj.setAmt(amountOfRoom);
                orderObj.setCardNo(threadName + 7000);
                orderObj.setSenderId(threadName);
                orderObj.setOrderId(_orderIds);
                orderObj.setSenderTime(DateTime.Now);
//                Thread.Sleep(1000);
                orderObj.setUnitPrice(roomPrice.price);
                String str = Coder.encoder(orderObj);
                
                Program.mcb.setOneCell(str);
            }
        }

        public void receiveTime(OrderClass orderObj, Double amountOfCharge)
        {
            orderObj.setReceiveTime(DateTime.Now); 
            Console.WriteLine();
            Console.WriteLine("Order ID: {0}, Agency ID: {1}, UnitPrice of Room: {2}, Amount of Room: {3}, Amount of Charge: {4}, Start Time: {5}, Completed Time: {6}, Time to process the order: {7}", orderObj.getOrderId(), orderObj.getSenderId() + 1, orderObj.getUnitPrice().ToString("f0"), orderObj.getAmt(), amountOfCharge.ToString("f0"), orderObj.getSenderTime(), orderObj.getReceiveTime(), (orderObj.getReceiveTime() - orderObj.getSenderTime()));
            pricecutLockCounter++;
            if (pricecutLockCounter == 10)
            {
                pricecutLock.Event.Set();
                pricecutLockCounter = 0;
                //            Console.WriteLine("Order ID: {0}, Agency ID: {1}, Unit Price: {3}, Amount of Room: {2}, Amount of Charge: {4}, Start Time: {5}, Completed Time: {6}, Time to process the order: {7}", orderObj.getOrderId(), orderObj.getSenderId() + 1, orderObj.getAmt(), roomPrice.price, amountOfCharge, orderObj.getSenderTime(), orderObj.getReceiveTime(), (orderObj.getReceiveTime() - orderObj.getSenderTime()));
                //            if (orderObj.getPriceCutId()<10)
                //                Console.WriteLine("No.{8} Price-cut, Order ID: {0}, Agency ID: {1}, Unit Price: {3}, Amount of Room: {2}, Amount of Charge: {4}, Start Time: {5}, Completed Time: {6}, Time to process the order: {7}", orderObj.getOrderId(), orderObj.getSenderId() + 1, orderObj.getAmt(), roomPrice.price, amountOfCharge, orderObj.getSenderTime(), orderObj.getReceiveTime(), (orderObj.getReceiveTime() - orderObj.getSenderTime()), orderObj.getPriceCutId() + 1);
            }
        }

        // calculate and return the amount of room to order
        public int calculateRoomAmount()
        {
            // set a fixed value as a basic amount
            amountOfRoom = 50;
            // room amount varies based on the difference between previous price and current price
            // i.e. the more price cut, the more rooms to order
            amountOfRoom = (int)(amountOfRoom * (roomPrice.previousPrice / roomPrice.price));
            return amountOfRoom;
        }

        //Event Handler
        public void bookingAvailable(double p, double p1, int counter)
        {
            roomPrice.previousPrice = p1;
            roomPrice.price = p;
            // each time PriceCut event triggered, agency threads will be released to send orders
            for (int j = 0; j < 10; j++)
                Event[j].Set();
            
            Console.WriteLine();
            if(counter<10)
                Console.WriteLine("           No.{0} Price-cut Availble {1}, {2} Off From Previous Price {3}", counter + 1, p.ToString("f0"), (p1 - p).ToString("f4"), p1.ToString("f0"));
        }
    }

    public class OrderClass
    {
        private Int32 senderId, cardNo, amountOfRoom, orderId;
        private double unitPrice;
        private DateTime senderTime, receiveTime;
        public OrderClass()
        { 
            senderId = 0;
            cardNo = 0;
            amountOfRoom = 0;
            orderId = 0;
            unitPrice = 0;
            senderTime = new DateTime();
            receiveTime = new DateTime();             
        }

        public void setUnitPrice(double _unitPrice)
        {
            unitPrice = _unitPrice;
        }

        public double getUnitPrice()
        {
            return unitPrice;
        }

        public void setOrderId(int _orderId)
        {            
            orderId = _orderId;
        }

        public int getOrderId()
        {            
            int _orderId = orderId;            
            return _orderId;
        }

        public Int32 getSenderId()
        { 
            int _senderId = senderId; 
            return _senderId;
        }

        public void setSenderId(int _senderId)
        { 
            this.senderId = _senderId; 
        }

        public Int32 getAmt()
        { 
            int _amountOfRoom = amountOfRoom; 
            return _amountOfRoom;
        }

        public void setAmt(Int32 _amountOfRoom)
        { 
            this.amountOfRoom = _amountOfRoom; 
        }

        public DateTime getSenderTime()
        { 
            DateTime _senderTime = senderTime; 
            return _senderTime;
        }

        public void setSenderTime(DateTime _senderTime)
        { 
            senderTime = _senderTime; 
        }

        public DateTime getReceiveTime()
        { 
            DateTime _receiveTime = receiveTime; 
            return _receiveTime;
        }

        public void setReceiveTime(DateTime _receiveTime)
        { 
            receiveTime = _receiveTime; 
        }

        public Int32 getCardNo()
        { 
            int _cardNo = cardNo; 
            return _cardNo;
        }

        public void setCardNo(Int32 _cardNo)
        { 
            this.cardNo = _cardNo; 
        }
    }

    public class MultiCellBuffer
    {
        private OrderInfo[] cell;
        static Semaphore empty = new Semaphore(3, 3);
        static Semaphore full = new Semaphore(0, 3);
        static Object mutex = new Object();
        static int index = 0;

        public MultiCellBuffer()
        {
            cell = new OrderInfo[3];
            cell[0] = new OrderInfo();
            cell[1] = new OrderInfo();
            cell[2] = new OrderInfo();
        }

        public void setOneCell(string str)
        {
            empty.WaitOne();


            lock (mutex)
            {

                cell[index].str = str;
                index++;
            }


            full.Release();
        }

        public string getOneCell()
        {
            full.WaitOne();
            string tempOrderString;
            lock (mutex)
            {
                index--;
                tempOrderString = cell[index].str;
                //  Console.WriteLine("temp:    {0}", tempOrderString);

            }

            empty.Release();

            return tempOrderString;
        }
    }


    class Coder
    {
        public static String encoder(OrderClass order)
        {
            if (order != null)
            {
                String orderId = order.getOrderId().ToString() + "&";
                String senderId = order.getSenderId().ToString() + "#";
                String cardNo = order.getCardNo().ToString() + "$";
                String unitPrice = order.getUnitPrice().ToString() + "?";
                String amountOfRoom = order.getAmt().ToString() + "%";
                String senderTime = order.getSenderTime().ToString() + "@";
                String str = orderId + senderId + cardNo + unitPrice + amountOfRoom + senderTime;
                HotelBookingSystem.CryptService.ServiceClient encrypt = new HotelBookingSystem.CryptService.ServiceClient();
                //               Console.WriteLine("string: {0}, encoded: {1}", order, encrypt.Encrypt(str));
                return encrypt.Encrypt(str);
            }
            else
            {
                return "Null order!";
            }
        }
        public static OrderClass decoder(String encodedString)
        {
            if (encodedString != null)
            {
                HotelBookingSystem.CryptService.ServiceClient decrypt = new HotelBookingSystem.CryptService.ServiceClient();
                String decodedString = decrypt.Decrypt(encodedString);
                int index = 0;
                String str = "";
                while (decodedString[index] != '&')
                {
                    str += decodedString[index].ToString();
                    index++;
                }
                Int32 orderId = Convert.ToInt32(str);
                str.Remove(0);
                str = "";
                index++;

                while (decodedString[index] != '#')
                {
                    str += decodedString[index].ToString();
                    index++;
                }
                Int32 senderId = Convert.ToInt32(str);
                str.Remove(0);
                str = "";
                index++;

                while (decodedString[index] != '$')
                {
                    str += decodedString[index].ToString();
                    index++;
                }
                Int32 cardNo = Convert.ToInt32(str);
                str.Remove(0);
                str = "";
                index++;

                while (decodedString[index] != '?')
                {
                    str += decodedString[index].ToString();
                    index++;
                }
                Double unitPrice = Convert.ToDouble(str);
                str.Remove(0);
                str = "";
                index++;

                while (decodedString[index] != '%')
                {
                    str += decodedString[index].ToString();
                    index++;
                }
                Int32 amountOfRoom = Convert.ToInt32(str);
                str.Remove(0);
                str = "";
                index++;

                while (decodedString[index] != '@')
                {
                    str += decodedString[index].ToString();
                    index++;
                }
                DateTime senderTime = Convert.ToDateTime(str);
                //              Console.WriteLine("OrderId: {0} SenderId: {1} CardNo: {2} Amount: {3} Date: {4}", orderId, senderId, cardNo, amountOfRoom, senderTime);
                OrderClass order = new OrderClass();
                order.setOrderId(orderId);
                order.setSenderId(senderId);
                order.setCardNo(cardNo);
                order.setUnitPrice(unitPrice);
                order.setAmt(amountOfRoom);
                order.setSenderTime(senderTime);
                return order;
            }
            else
            {
                Console.WriteLine("Null string!");
                return null;
            }
        }
    }

    class OrderInfo
    {
        public string str = "";
        public bool flag = false;
    }    

    public class DoubleValue
    {
        public double price;
        public double previousPrice;
    }

    class Program
    {
        public static MultiCellBuffer mcb = new MultiCellBuffer();

        static void Main(string[] args)
        {
            TravelAgency agency = new TravelAgency();
           

            // start a thread using PricingModel method to calculate the room price, if the current price
            // is lower than the previous one, trigger the priceCut event
            Thread calculateRoomPrice = new Thread(new ThreadStart(TravelAgency.hotel.PricingModel));
            calculateRoomPrice.Start();

            // start a thread using orderProcessing method to receive orders from travel agencys and process
            // the orders, if an order is completed, trigger the orderCompleted event
            Thread order = new Thread(new ThreadStart(TravelAgency.hotel.orderProcessing));
            order.Start();

            // method(event handler) bookingAvailable(..) subscripts priceCut event
            HotelSupplier.priceCut += new priceCutEvent(agency.bookingAvailable);

            // method receiveTime(..) subscripts orderCompleted event
            HotelSupplier.orderCompleted += new orderCompletedEvent(agency.receiveTime);

            // start 10 travel agencys thread
            Thread[] agencys = new Thread[10];
            for (int i = 0; i < 10; i++)
            {
                agencys[i] = new Thread(new ThreadStart(agency.agencyFunc));
                // evaluate agency thread name from 1 to 10
                agencys[i].Name = (i).ToString();
                agencys[i].Start();
            }

            while (true)
            {
                // terminate getOrder thread and all travel agencys thread when calculateRoomPrice terminated
                if (!calculateRoomPrice.IsAlive)
                {
                    order.Abort();
                    for (int i = 0; i < 10; i++)
                        agencys[i].Abort();
                }
            }

        }
    }
}
