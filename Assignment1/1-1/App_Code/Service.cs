//******************************************************************************************************************************
//Name: Shihuan Shao
//ASUID: 1203060451
//Assignment 1, Section 3, Question 1
//Description: A web service that provides two methods to do conversion between Fahrenheit and Celsius temperatures. 
//******************************************************************************************************************************
using System;
using System.ServiceModel;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    public int c2f(int c)
    {
        return c * 9 / 5 + 32;
    }

    public int f2c(int f)
    {
        return (f - 32) * 5 / 9;
    }
}
