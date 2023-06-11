//Got this code from stackoverflow to help with the spinner animation;
//Just adapted the symbols.
public class Spinner
 {
     private readonly int delay;
     private int counter;
     private string text;
     private bool isRunning = false;
     private Thread thread;
     public Spinner(int delay = 250, string text = "")
     {
        this.text = text;
        this.delay = delay;
        this.counter = 0;
     }

     public void Start()
     {
         if (!isRunning)
         {
             isRunning = true;
             thread = new Thread(Spin);
             thread.Start();
         }
     }
     public void Stop()
     {
         isRunning = false;
     }

     private void Spin()
     {
         while (isRunning)
         {
            counter++;        
            switch (counter % 4)
            {
                case 0: Console.Write($"\r{text}/"); break;
                case 1: Console.Write($"\r{text}-"); break;
                case 2: Console.Write($"\r{text}\\"); break;
                case 3: Console.Write($"\r{text}|"); break;
            }
             Thread.Sleep(delay);
         }
     }
 }