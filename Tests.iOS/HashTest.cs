﻿using System;
using System.Diagnostics;
using System.Text;
using NUnit.Framework;
using Virgil.Crypto;

namespace Tests.iOS
{
    public class HashTest
    {
        [Test]
        public void DoHashTest()
        {
            try{
                var p = new Virgil.Crypto.pythia.VirgilPythia();

                //var crypto = new VirgilCrypto();
                //var hash = crypto.GenerateHash(Encoding.UTF8.GetBytes("hi"));
            }
            catch(Exception e)
            {
                Debug.Write(e.StackTrace);
            }
           
        }
    }
}
