namespace Models;

public class Transaction{

    public decimal Amounts {get;}

    public DateTime Date {get;}

    public string Note {get;}="";


public Transaction(decimal amount,DateTime date,string note){
    this.Amounts=amount;
    this.Date=date;
    this.Note=note;
}
}