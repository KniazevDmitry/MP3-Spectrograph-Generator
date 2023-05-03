using NAudio.Wave;

namespace MP3_Spectrograph_Generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the path to the MP3 file: ");
            string filePath = Console.ReadLine();
        }

        static int GetSampleRate (string filePath)
        {
            
            int sampleRate = 0;
            Mp3Frame mp3FileFrame = null;

            return sampleRate;
        }
    }


}