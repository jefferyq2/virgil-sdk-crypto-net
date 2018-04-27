﻿using System;
using System.Text;
using Virgil.Crypto;

namespace Tests.CoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("VirgilVersion=" + VirgilVersion.AsString());
            var s = new Virgil.Crypto.Pfs.VirgilPFS();
            var v = new Virgil.Crypto.VirgilCrypto();
            var p = new Virgil.Crypto.Pythia.VirgilPythia();
            //var crypto = new VirgilCrypto();
            //var hash = crypto.GenerateHash(Encoding.UTF8.GetBytes("hi"));
        }
    }
}
 