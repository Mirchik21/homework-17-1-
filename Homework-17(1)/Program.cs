namespace Homework_17_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dear subscriber, thank you for choosing our TV provider -ALA-TOO-TV-");
            TV my_tv = new TV(); 
        }
    }
    class TV
    {
        Random rand = new Random();
        int _currentChannel;
        int _channelLimit;
        string NxtOrPrevChannel;
        public TV ()
        {
            _currentChannel = rand.Next(1, 10 + 1 );
            PrintChannel(_currentChannel);
            NextOrPreviosChannel();
            _channelLimit = 10;
            if (_currentChannel > _channelLimit)
            {
                _currentChannel = 1;
                PrintChannel(_currentChannel);
            }
            if (_currentChannel < 0)
            {
                _currentChannel = 10;
                PrintChannel(_currentChannel);
            }
        }
        public void NextOrPreviosChannel()
        {
            Console.WriteLine("Press + or - to move the channel.");
            NxtOrPrevChannel = Console.ReadLine();
            switch (NxtOrPrevChannel)
            {
                case "+":
                    Console.WriteLine("The channel moves forward...");
                    NextChannel();
                    NextOrPreviosChannel();
                    break;
                case "-":
                    Console.WriteLine("The channel moves backwards...");
                    PreviousChannel();
                    NextOrPreviosChannel();
                    break;
                default:
                    Console.WriteLine("Do not enter incorrect characters.");
                    MoveToChannel();
                    NextOrPreviosChannel();
                    break;
            }
        }
        public void NextChannel()
        {
            Console.WriteLine("The next channel is: ");
            _currentChannel += 1;
            PrintChannel(_currentChannel);
        }
        public void PreviousChannel()
        {
            Console.WriteLine("The previous channel is: ");
            _currentChannel -= 1;
            PrintChannel(_currentChannel);

        }
        public void MoveToChannel() 
        {
            Console.WriteLine("To select a channel press from 1 to 10, the moves channel is: ");
            _currentChannel = Convert.ToInt32(Console.ReadLine());
            PrintChannel(_currentChannel);
        }
        static void PrintChannel(int number)
        {
            switch (number)
            {
                case 1:
                    Console.WriteLine("We present to your attention the first channel called -sport TV-");
                    break;
                case 2:
                    Console.WriteLine("We present to your attention the second channel called - culture tv -");
                    break;
                case 3:
                    Console.WriteLine("We present to your attention the third channel called -art TV-");
                    break;
                case 4:
                    Console.WriteLine("We present to your attention the fourth channel called -politics TV-");
                    break;
                case 5:
                    Console.WriteLine("To your attention we present the fifth channel called -food tv-");
                    break;
                case 6:
                    Console.WriteLine("We present to your attention the sixth channel called -style TV-");
                    break;
                case 7:
                    Console.WriteLine("To your attention we present the seventh channel called -children tv-");
                    break;
                case 8:
                    Console.WriteLine("We present to your attention the eighth channel called -national TV-");
                    break;
                case 9:
                    Console.WriteLine("We present to your attention the ninth channel called -tv news-");
                    break;
                case 10:
                    Console.WriteLine("We present to your attention the tenth channel called -Kyrgyzstan TV-");
                    break;
                default:
                    Console.WriteLine("Please enter the correct channel number, select from 1 to 10.");

                    break;
            }
        }
    }
}