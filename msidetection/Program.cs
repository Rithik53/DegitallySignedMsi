using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        string filePath = @"C:\Users\demo.exe"; //add the path of your MSI 

        try
        {
            // Load the MSI file as an X509Certificate2
            X509Certificate2 cert = new X509Certificate2(filePath);

            // Check if the certificate exists and has a valid signature
            if (cert != null && cert.Verify())
            {
                Console.WriteLine("The file is digitally signed.");
                Console.WriteLine("Certificate Information:");
                Console.WriteLine($"Subject: {cert.Subject}");
                Console.WriteLine($"Issuer: {cert.Issuer}");
                Console.WriteLine($"Thumbprint: {cert.Thumbprint}");
                // Additional certificate details can be accessed similarly
            }
            else
            {
                Console.WriteLine("The file is not digitally signed or the signature is invalid.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
            // Handle the exception as needed
        }
    }
}
