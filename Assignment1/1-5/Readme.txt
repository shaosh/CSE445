This project contains a web  browser  that  can  take  any URL and display the content of the page in the upper part of the window, a WCF client which encrypt a string and at the same time decrypt the encrypted string for validation, and a WCF client which generate random strings.

How to use: 
for the web brower, enter the address into the textbox at the top and click button Go;
for the encryption client, enter your string and click the button Encrypt, the readOnly textboxes (because only encrypted string can be decrypted, I make it readOnly) will show you the encrypted result and at the same time decrypt the resulted string;
for the random string client, click button Random I, you will get a random string with length from 4 to 20; enter an positive integer in the textbox and click the button Random II, you will see the a random string with the length you just entered in the textbox.

WSDL address: http://venus.eas.asu.edu/WSRepository/Services/EncryptionWcf/Service.svc?wsdl for encryption
                         http://venus.eas.asu.edu/WSRepository/Services/RandomStringSvc/Service.svc?wsdl for random string 
