// See https://aka.ms/new-console-template for more information
using Models;



User userAdmin =new User{
    Name="admin",
    Lastname="nistrator",
    Nif="3343454k"
};

User user =new User{
    Name="guille",
    Lastname="garcia",
    Nif="334994k"
};

Console.WriteLine("datos del usuario "  +user.ToString());




// DICCIONARIOS EJEMPLOS
// es como un array pero con claves
// <clave,valor>
Dictionary<int,User> users=new Dictionary<int,User>(){
    //clave y valor, y puedo crearlo directamente dentro    
    {100,userAdmin},{101,user},{102,new User{
        Name="toñin",
        Lastname="Coliseum",
        Nif="usado"
    }}
};
//accedo al diccionario, indico la clave
Console.WriteLine(users[100].Name);

users.Add(103,userAdmin);//añadir al diccionario, no repetir la key

//desde donde empieza y cuantos recorre, 100,3
foreach(var index in Enumerable.Range(100,3)){
    Console.WriteLine(users[index].ToString());
}


//al crear un constructor vacio en backaccount puedo hacer esto y las declaro aqui
BankAccount bank=new BankAccount{
    Number="22323343",
    numerico=10,
    Owner="alex"
};


BankAccount account=new BankAccount("guillermo",100);
account.MakeDeposit(5000,DateTime.Now,"Colacao");
account.MakeDeposit(2000,DateTime.Now,"Churros");
var history=account.GetAccountHistory();
Console.WriteLine(history); 
// try{
// account.MakeDeposit(-2000,DateTime.Now,"hola");
// }catch(ArgumentOutOfRangeException e){
//     Console.WriteLine("Exception " + e.ToString());
// }catch(Exception e){
//     Console.WriteLine("Exception " + e.ToString());

// }

// try{
// account.MakeWithdrawal(200,DateTime.Now,"bus");
// }catch(ArgumentOutOfRangeException e){
//     Console.WriteLine("ArgumentOutOfRangeException " + e.ToString());
// }catch(Exception e){
//     Console.WriteLine("Exception " + e.ToString());

// }

// try{
// account.MakeWithdrawal(-200,DateTime.Now,"bus");
// }catch(ArgumentOutOfRangeException e){
//     Console.WriteLine("ArgumentOutOfRangeException " + e.ToString());
// }catch(InvalidOperationException e){
//     Console.WriteLine("InvalidOperationException " + e.ToString());

// }


// try{
// account.MakeWithdrawal(10000000,DateTime.Now,"hipoteca");
// }catch(ArgumentOutOfRangeException e){
//     Console.WriteLine("ArgumentOutOfRangeException " + e.ToString());
// }catch(InvalidOperationException e){
//     Console.WriteLine("InvalidOperationException " + e.ToString());

// }


//controlamos los valores negativos con el throw
// var balance=account.Balance;
// Console.WriteLine(account.Balance);
// var stringifyAccount=account.ToString();
// Console.WriteLine(stringifyAccount);

InterestEarningAccount nuevaCuenta=new InterestEarningAccount("Marcos",1000);

nuevaCuenta.MakeDeposit(1000,DateTime.Now,"Cumpleaños");
nuevaCuenta.PerformMonthlyOperation();//simulo que ha pasado el mes y cobro el interes
Console.WriteLine(nuevaCuenta.GetAccountHistory());



CreditCardAccount creditCard= new CreditCardAccount("guille",550);
creditCard.MakeWithdrawal(650,DateTime.Now,"season pass");
// creditCard.MakeWithdrawal(100,DateTime.Now,"supuesto bus");
// creditCard.PerformMonthlyOperation();
creditCard.PerformMonthlyDiscount();
creditCard.MakeDeposit(206,DateTime.Now,"cumple");


Console.WriteLine(creditCard.GetAccountHistory());

