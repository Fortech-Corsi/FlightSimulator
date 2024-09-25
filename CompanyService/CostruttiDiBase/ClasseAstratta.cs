namespace CompanyService.CostruttiDiBase;

/*
    •   Una classe astratta è una classe che non può essere istanziata (cioè non è possibile creare oggetti di questa classe).
   •   Quindi una classe astratta deve essere derivata.
   •   Una classe astratta può contenere membri astratti ma anche membri non astratti.
   •   La classe derivata dalla classe astratta, deve implementare i membri astratti facendone l'override. In alternativa potrebbe anche non implementarli tutti, ma in questo caso deve essere a sua volta astratta.
 */

/*
 Differenze tra Interfacce e Classi Astratte
   •   Una classe astratta può avere dei metodi implementati, una interfaccia no.
   •   Una classe astratta può avere campi, una interfaccia no.
   •   Una classe astratta può ereditare da una interfaccia, viceversa no.
 */


abstract class ClasseAstratta
{
    public abstract int ProprietaAstratta1 { get; set; }
    public abstract int ProprietaAstratta2 { get; set; }
    public abstract void MetodoAstratto1();
    public abstract void MetodoAstratto2();

    int ProprietaPrivata;
    public int ProprietaPubblica;
    void MetodoPrivato()
    { }
    public void MetodoPubblico()
    { }
}

class MyClass : ClasseAstratta
{
    public override int ProprietaAstratta1 { get; set; }
    public override int ProprietaAstratta2 { get; set; }
    public override void MetodoAstratto1()
    { }
    public override void MetodoAstratto2()
    { }
}
