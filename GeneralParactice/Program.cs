//NOTES
//Teacher inherits Employee and implements INotification at the same time
//Octagon demonstrates explicit implementation of IDrawToForm, IDrawToMemory, IDrawToPrinter
//DrawUpsideDown implements all members in hierarcy (IAdvancedDraw which inherit from IDrawable)


using GeneralParactice;

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
        IDrawToForm drawToForm = new Octagon();         //Explicitly implemented interface
        IDrawToMemory drawToMemory = new Octagon();     //Explicitly implemented interface
        IDrawToPrinter printToPrinter = new Octagon();  //Explicitly implemented interface
        drawToForm.Draw();
        drawToMemory.Draw();
        printToPrinter.Draw();
        //####################################################################################

        ////DrawUpsideDown implements all members in hierarcy (IAdvancedDraw extends IDrawable)
        BitmapImage bitmapImage = new BitmapImage();
        bitmapImage.Draw();
        bitmapImage.DrawInBoundingBox(3, 4, 5, 6);
        bitmapImage.DrawUpsideDown();

        //####################################################################################
        Console.ReadKey();
    }
}