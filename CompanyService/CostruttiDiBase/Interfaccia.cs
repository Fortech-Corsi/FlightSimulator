namespace CompanyService.CostruttiDiBase;

/*
   •   Una interfaccia è un insieme di 'firme' di proprietà, metodi, delegati e eventi. Per firme si intende che le proprietà, i metodi e gli eventi sono solo definiti come nome, parametri di input e di output, ma non ne è specificato il funzionamento.
   •   Per essere utilizzabile, una interfaccia deve essere 'implementata' da una classe, che ne specifica quindi il funzionamento nel dettaglio.
   •   Una interfaccia non può essere istanziata e non contiene codice che definisce i suoi membri, semplicemente definisce solo i membri. È la classe che implementa l'interfaccia che definisce i membri.
   •   Una classe può implementare più interfacce, così come più classi possono implementare la stessa interfaccia.
   •   Tramite una interfaccia è quindi possibile sostituire un oggetto con un altro, o con un aggiornamento dello stesso oggetto, purché implementino la stessa interfaccia.
   •   Per convenzione le interfacce hanno nomi che iniziano con 'I'.
   •   Una volta pubblicata una interfaccia è buona regola non modificarla per non causare problemi agli oggetti che la implementano. Se occorre modificarla, se ne crea un'altra con un nuovo nome (tipicamente lo stesso nome seguito da 'X2').
   •   Non è possibile istanziare una interfaccia ma si può creare una variabile che punta a ad una istanza di una classe derivata dall'interfaccia. (Esempio: interfaccia I1, classe derivata C1, istanza dell'oggetto c1 dalla classe C1, variabile i1 che punta allo stesso indirizzo di c1).
 */


class Program
{
    static void Main(string[] args)
    {
        ILog log = new MyLog();
        log.Print("Log message.");
        Console.ReadKey();
    }
}

interface ILog
{
    void Print(string message);
}

class MyLog : ILog
{
    public void Print(string message)
    {
        Console.WriteLine(message);
    }
}