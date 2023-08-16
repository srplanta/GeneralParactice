//NOTES
//Teacher inherits Employee and implements INotification at the same time
//Octagon demonstrates explicit implementation of IDrawToForm, IDrawToMemory, IDrawToPrinter
//BitmapImage implements all members in hierarcy (IAdvancedDraw which inherit from IDrawable)


using GeneralParactice;
public delegate void DelegateDemoAddition(int a, int b);
internal class Program
{
    private static void Main(string[] args)
    {
        ////Teacher inherits Employee and implements INotification at the same time
        ////not any active functionality
        //Teacher teacher = new Teacher();    //teacher is inherited from Employee class
        //teacher.Id = 1;
        //####################################################################################

        ////Octagon demonstrates explicit implementation of IDrawToForm, IDrawToMemory, IDrawToPrinter
        //IDrawToForm drawToForm = new Octagon();         //Explicitly implemented interface
        //IDrawToMemory drawToMemory = new Octagon();     //Explicitly implemented interface
        //IDrawToPrinter printToPrinter = new Octagon();  //Explicitly implemented interface
        //drawToForm.Draw();
        //drawToMemory.Draw();
        //printToPrinter.Draw();
        //####################################################################################

        ////BitmapImage implements all members in hierarcy (IAdvancedDraw extends IDrawable)
        //BitmapImage bitmapImage = new BitmapImage();
        //bitmapImage.Draw();
        //bitmapImage.DrawInBoundingBox(3, 4, 5, 6);
        //bitmapImage.DrawUpsideDown();

        //####################################################################################

        //IndexerDemo indexerDemo = new IndexerDemo();
        //indexerDemo[12] = 5;
        //Console.WriteLine(indexerDemo[0]);
        //####################################################################################

        Console.WriteLine("Delegate Demonstration!");
        DelegateDemoAddition delegateDemoAddition = new DelegateDemoAddition(DelegateDemo.Add);
        delegateDemoAddition.Invoke(5, 13);     //same as below normal method call
        delegateDemoAddition(5, 13);            //same as above invoke method
        Console.ReadLine();
        //####################################################################################
        Console.ReadKey();
    }
}