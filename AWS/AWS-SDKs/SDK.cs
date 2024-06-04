using System;
using System.Threading.Tasks;
using Amazon.Polly;
using Amazon.Polly.Model;

namespace PollyExample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Create an Amazon Polly client
            var pollyClient = new AmazonPollyClient();

            // Set up the synthesize speech request
            var synthesizeSpeechRequest = new SynthesizeSpeechRequest
            {
                OutputFormat = OutputFormat.Mp3,
                SampleRate = SampleRate.SixteenKilohertz,
                Text = "Hello, world!",
                TextType = TextType.Text,
                VoiceId = VoiceId.Joanna
            };

            // Synthesize the speech
            var synthesizeSpeechResponse = await pollyClient.SynthesizeSpeechAsync(synthesizeSpeechRequest);

            // Save the synthesized speech to a file
            using (var fileStream = System.IO.File.OpenWrite("speech.mp3"))
            {
                await synthesizeSpeechResponse.AudioStream.CopyToAsync(fileStream);
            }

            Console.WriteLine("Speech synthesized and saved to speech.mp3.");
        }
    }
}