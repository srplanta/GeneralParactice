
//Teacher inherits Employee and implements INotification at the same time
//Octagon demonstrates explicit implementation of IDrawToForm, IDrawToMemory, IDrawToPrinter
//DrawUpsideDown implements all members in hierarcy (IAdvancedDraw which inherit from IDrawable)


using GeneralParactice;

internal class Program
{
    private static void Main(string[] args)
    {
        ////Teacher inherits Employee and implements INotification at the same time
        //Teacher teacher = new Teacher();    //teacher is inherited from Employee class
        //teacher.Id = 1;
        //####################################################################################

        ////Octagon demonstrates explicit implementation of IDrawToForm, IDrawToMemory, IDrawToPrinter
        //Octagon octagon = new Octagon();
        //IDrawToForm drawToForm = (IDrawToForm)octagon;
        //drawToForm.Draw();
        //IDrawToMemory drawToMemory = (IDrawToMemory)octagon;
        //drawToMemory.Draw();
        //IDrawToPrinter drawToPrinter = (IDrawToPrinter)octagon;
        //drawToPrinter.Draw();
        //---------------------------------------------------------------------

        //IDrawToForm drawToForm = new Octagon();         //Explicitly implemented interface
        //IDrawToMemory drawToMemory = new Octagon();     //Explicitly implemented interface
        //IDrawToPrinter printToPrinter = new Octagon();  //Explicitly implemented interface
        //drawToForm.Draw();
        //drawToMemory.Draw();
        //printToPrinter.Draw();
        //####################################################################################

        ////DrawUpsideDown implements all members in hierarcy (IAdvancedDraw which inherit from IDrawable)
        BitmapImage bitmapImage = new BitmapImage();
        bitmapImage.Draw();
        bitmapImage.DrawInBoundingBox(3, 4, 5, 6);
        bitmapImage.DrawUpsideDown();

        //####################################################################################
        Console.ReadKey();
    }
}