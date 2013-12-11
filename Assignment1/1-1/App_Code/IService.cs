//******************************************************************************************************************************
//Name: Shihuan Shao
//ASUID: 1203060451
//Assignment 1, Section 3, Question 1
//Description: A web service that provides two methods to do conversion between Fahrenheit and Celsius temperatures. 
//******************************************************************************************************************************
using System;
using System.ServiceModel;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IService
{
    // TODO: Add your service operations here
    [OperationContract]
    int c2f(int c);

    [OperationContract]
    int f2c(int f);
}