using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;
using System;

namespace Tuldok.Hash.Test
{
    [TestClass]
    public class HashTest
    {
        [TestMethod]
        public void TestCrc32()
        {
            var crc32 = new Crc32();
            var bytes = Encoding.UTF8.GetBytes("123456789");

            var hash = crc32.ComputeHash(bytes);
            var crc = BitConverter.ToUInt32(hash);
            Assert.AreEqual(crc, 0xcbf43926);
        }

        [TestMethod]
        public void TestCrc32c()
        {
            var crc32c = new Crc32c();
            var bytes = Encoding.UTF8.GetBytes("123456789");

            var hash = crc32c.ComputeHash(bytes);
            var crc = BitConverter.ToUInt32(hash);

            Assert.AreEqual(crc, 0xe3069283);
        }

        [TestMethod]
        public void TestSha1()
        {
            var sha1 = new Sha1();
            var bytes = Encoding.UTF8.GetBytes("abc");

            var hash = sha1.ComputeHash(bytes);
            var sha1str = BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();

            Assert.AreEqual(sha1str, "a9993e364706816aba3e25717850c26c9cd0d89d");
        }

        [TestMethod]
        public void TestSha256()
        {
            var sha256 = new Sha256();
            var bytes = Encoding.UTF8.GetBytes("abc");

            var hash = sha256.ComputeHash(bytes);
            var sha256str = BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();

            Assert.AreEqual(sha256str, "ba7816bf8f01cfea414140de5dae2223b00361a396177a9cb410ff61f20015ad");
        }

        [TestMethod]
        public void TestSha224()
        {
            var sha224 = new Sha224();
            var bytes = Encoding.UTF8.GetBytes("abc");

            var hash = sha224.ComputeHash(bytes);
            var sha224str = BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();

            Assert.AreEqual(sha224str, "23097d223405d8228642a477bda255b32aadbce4bda0b3f7e36c9da7");
        }

        [TestMethod]
        public void TestSha384()
        {
            var sha384 = new Sha384();
            var bytes = Encoding.UTF8.GetBytes("abc");

            var hash = sha384.ComputeHash(bytes);
            var sha384str = BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();

            Assert.AreEqual(sha384str, "cb00753f45a35e8bb5a03d699ac65007272c32ab0eded1631a8b605a43ff5bed8086072ba1e7cc2358baeca134c825a7");
        }

        [TestMethod]
        public void TestSha512()
        {
            var sha512 = new Sha512();
            var bytes = Encoding.UTF8.GetBytes("abc");

            var hash = sha512.ComputeHash(bytes);
            var sha512str = BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();

            Assert.AreEqual(sha512str, "ddaf35a193617abacc417349ae20413112e6fa4e89a97ea20a9eeee64b55d39a2192992a274fc1a836ba3c23a3feebbd454d4423643ce80e2a9ac94fa54ca49f");
        }

        [TestMethod]
        public void TestSha3_224()
        {
            var sha3_224 = new Sha3_224();
            var bytes = Encoding.UTF8.GetBytes("abc");
            var hash = sha3_224.ComputeHash(bytes);
            var sha3_224str = BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();

            Assert.AreEqual(sha3_224str, "e642824c3f8cf24ad09234ee7d3c766fc9a3a5168d0c94ad73b46fdf");
        }

        [TestMethod]
        public void TestSha3_256()
        {
            var sha3_256 = new Sha3_256();
            var bytes = Encoding.UTF8.GetBytes("abc");
            var hash = sha3_256.ComputeHash(bytes);
            var sha3_256str = BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();

            Assert.AreEqual(sha3_256str, "3a985da74fe225b2045c172d6bd390bd855f086e3e9d525b46bfe24511431532");
        }

        [TestMethod]
        public void TestSha3_384()
        {
            var sha3_384 = new Sha3_384();
            var bytes = Encoding.UTF8.GetBytes("abc");
            var hash = sha3_384.ComputeHash(bytes);
            var sha3_384str = BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();

            Assert.AreEqual(sha3_384str, "ec01498288516fc926459f58e2c6ad8df9b473cb0fc08c2596da7cf0e49be4b298d88cea927ac7f539f1edf228376d25");
        }

        [TestMethod]
        public void TestSha3_512()
        {
            var sha3_512 = new Sha3_512();
            var bytes = Encoding.UTF8.GetBytes("abc");
            var hash = sha3_512.ComputeHash(bytes);
            var sha3_512str = BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();

            Assert.AreEqual(sha3_512str, "b751850b1a57168a5693cd924b6b096e08f621827444f70d884f5d0240d2712e10e116e9192af3c91a7ec57647e3934057340b4cf408d5a56592f8274eec53f0");
        }

        [TestMethod]
        public void TestBlake2s()
        {
            var blake2 = new Blake2s();
            var bytes = Encoding.UTF8.GetBytes("abcdefghijklmnopqrstuvwxyz0123456789abcdefghijklmnopqrstuvwxyz0123456789");
            var hash = blake2.ComputeHash(bytes);
            var hashStr = BitConverter.ToString(hash).Replace("-", "");
            Assert.AreEqual(hashStr, "44DDDB39BDB2AF80C147894C1D756ADA3D1C2AC2B100541E04FE87B4A59E1243");
        }

        [TestMethod]
        public void TestBlake2b()
        {
            var blake2 = new Blake2b();
            var bytes = Encoding.UTF8.GetBytes("abcdefghijklmnopqrstuvwxyz0123456789abcdefghijklmnopqrstuvwxyz0123456789abcdefghijklmnopqrstuvwxyz0123456789abcdefghijklmnopqrstuvwxyz0123456789");
            var hash = blake2.ComputeHash(bytes);
            var hashStr = BitConverter.ToString(hash).Replace("-", "");
            Assert.AreEqual(hashStr, "FFD4A61F80D55FFA83BA8D2BD62DCFC33148ADE507A8F7F85A5AF2C619E126FF11E9284F12BF3EE6A2B5CBC711FA84C37DA343AB7D29BCDF722DF0171E41297A");
        }

        [TestMethod]
        public void TestKeccak_256()
        {
            var keccak_256 = new Keccak_256();
            var bytes = Encoding.UTF8.GetBytes("The quick brown fox jumps over the lazy dog");
            var hash = keccak_256.ComputeHash(bytes);
            var hashStr = BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
            Assert.AreEqual(hashStr, "4d741b6f1eb29cb2a9b9911c82f56fa8d73b04959d3d9d222895df6c0b28aa15");
        }

        [TestMethod]
        public void TestKeccak_224()
        {
            var keccak_224 = new Keccak_224();
            var bytes = Encoding.UTF8.GetBytes("The quick brown fox jumps over the lazy dog");
            var hash = keccak_224.ComputeHash(bytes);
            var hashStr = BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
            Assert.AreEqual(hashStr, "310aee6b30c47350576ac2873fa89fd190cdc488442f3ef654cf23fe");
        }

        [TestMethod]
        public void TestKeccak_384()
        {
            var keccak_384 = new Keccak_384();
            var bytes = Encoding.UTF8.GetBytes("The quick brown fox jumps over the lazy dog");
            var hash = keccak_384.ComputeHash(bytes);
            var hashStr = BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
            Assert.AreEqual(hashStr, "283990fa9d5fb731d786c5bbee94ea4db4910f18c62c03d173fc0a5e494422e8a0b3da7574dae7fa0baf005e504063b3");
        }

        [TestMethod]
        public void TestKeccak_512()
        {
            var keccak_512 = new Keccak_512();
            var bytes = Encoding.UTF8.GetBytes("The quick brown fox jumps over the lazy dog");
            var hash = keccak_512.ComputeHash(bytes);
            var hashStr = BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
            Assert.AreEqual(hashStr, "d135bb84d0439dbac432247ee573a23ea7d3c9deb2a968eb31d47c4fb45f1ef4422d6c531b5b9bd6f449ebcc449ea94d0a8f05f62130fda612da53c79659f609");
        }
    }
}
