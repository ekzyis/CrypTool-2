﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.TemplateAndPluginTests
{
    [TestClass]
    public class RC4Test
    {
        public RC4Test()
        {
        }

        [TestMethod]
        public void RC4TestMethod()
        {
            CrypTool.PluginBase.ICrypComponent pluginInstance = TestHelpers.GetPluginInstance("RC4");
            PluginTestScenario scenario = new PluginTestScenario(pluginInstance, new[] { "InputData", "InputKey", ".Keylength" }, new[] { "OutputStream" });

            foreach (TestVector vector in testvectors)
            {
                object[] output = scenario.GetOutputs(new object[] { (new byte[vector.offset + vector.output.Length / 2]).ToStream(), vector.key.HexToStream(), (int)vector.key.HexToStream().Length });
                Assert.AreEqual(vector.output.ToUpper(), output[0].ToHex().Substring(vector.offset * 2), "Unexpected value in test #" + vector.n + ".");
            }
        }

        private struct TestVector
        {
            public string key, output;
            public int n, offset, keylength;
        }

        //
        // Source of the test vectors: http://tools.ietf.org/html/rfc6229
        //
        private readonly TestVector[] testvectors = new TestVector[] {
            new TestVector () { n=0, key="0102030405", offset=   0, output="b2396305f03dc027ccc3524a0a1118a8" },
            new TestVector () { n=1, key="0102030405", offset=  16, output="6982944f18fc82d589c403a47a0d0919" },
            new TestVector () { n=2, key="0102030405", offset= 240, output="28cb1132c96ce286421dcaadb8b69eae" },
            new TestVector () { n=3, key="0102030405", offset= 256, output="1cfcf62b03eddb641d77dfcf7f8d8c93" },
            new TestVector () { n=4, key="0102030405", offset= 496, output="42b7d0cdd918a8a33dd51781c81f4041" },
            new TestVector () { n=5, key="0102030405", offset= 512, output="6459844432a7da923cfb3eb4980661f6" },
            new TestVector () { n=6, key="0102030405", offset= 752, output="ec10327bde2beefd18f9277680457e22" },
            new TestVector () { n=7, key="0102030405", offset= 768, output="eb62638d4f0ba1fe9fca20e05bf8ff2b" },
            new TestVector () { n=8, key="0102030405", offset=1008, output="45129048e6a0ed0b56b490338f078da5" },
            new TestVector () { n=9, key="0102030405", offset=1024, output="30abbcc7c20b01609f23ee2d5f6bb7df" },
            new TestVector () { n=10, key="0102030405", offset=1520, output="3294f744d8f9790507e70f62e5bbceea" },
            new TestVector () { n=11, key="0102030405", offset=1536, output="d8729db41882259bee4f825325f5a130" },
            new TestVector () { n=12, key="0102030405", offset=2032, output="1eb14a0c13b3bf47fa2a0ba93ad45b8b" },
            new TestVector () { n=13, key="0102030405", offset=2048, output="cc582f8ba9f265e2b1be9112e975d2d7" },
            new TestVector () { n=14, key="0102030405", offset=3056, output="f2e30f9bd102ecbf75aaade9bc35c43c" },
            new TestVector () { n=15, key="0102030405", offset=3072, output="ec0e11c479dc329dc8da7968fe965681" },
            new TestVector () { n=16, key="0102030405", offset=4080, output="068326a2118416d21f9d04b2cd1ca050" },
            new TestVector () { n=17, key="0102030405", offset=4096, output="ff25b58995996707e51fbdf08b34d875" },
            new TestVector () { n=18, key="01020304050607", offset=   0, output="293f02d47f37c9b633f2af5285feb46b" },
            new TestVector () { n=19, key="01020304050607", offset=  16, output="e620f1390d19bd84e2e0fd752031afc1" },
            new TestVector () { n=20, key="01020304050607", offset= 240, output="914f02531c9218810df60f67e338154c" },
            new TestVector () { n=21, key="01020304050607", offset= 256, output="d0fdb583073ce85ab83917740ec011d5" },
            new TestVector () { n=22, key="01020304050607", offset= 496, output="75f81411e871cffa70b90c74c592e454" },
            new TestVector () { n=23, key="01020304050607", offset= 512, output="0bb87202938dad609e87a5a1b079e5e4" },
            new TestVector () { n=24, key="01020304050607", offset= 752, output="c2911246b612e7e7b903dfeda1dad866" },
            new TestVector () { n=25, key="01020304050607", offset= 768, output="32828f91502b6291368de8081de36fc2" },
            new TestVector () { n=26, key="01020304050607", offset=1008, output="f3b9a7e3b297bf9ad804512f9063eff1" },
            new TestVector () { n=27, key="01020304050607", offset=1024, output="8ecb67a9ba1f55a5a067e2b026a3676f" },
            new TestVector () { n=28, key="01020304050607", offset=1520, output="d2aa902bd42d0d7cfd340cd45810529f" },
            new TestVector () { n=29, key="01020304050607", offset=1536, output="78b272c96e42eab4c60bd914e39d06e3" },
            new TestVector () { n=30, key="01020304050607", offset=2032, output="f4332fd31a079396ee3cee3f2a4ff049" },
            new TestVector () { n=31, key="01020304050607", offset=2048, output="05459781d41fda7f30c1be7e1246c623" },
            new TestVector () { n=32, key="01020304050607", offset=3056, output="adfd3868b8e51485d5e610017e3dd609" },
            new TestVector () { n=33, key="01020304050607", offset=3072, output="ad26581c0c5be45f4cea01db2f3805d5" },
            new TestVector () { n=34, key="01020304050607", offset=4080, output="f3172ceffc3b3d997c85ccd5af1a950c" },
            new TestVector () { n=35, key="01020304050607", offset=4096, output="e74b0b9731227fd37c0ec08a47ddd8b8" },
            new TestVector () { n=36, key="0102030405060708", offset=   0, output="97ab8a1bf0afb96132f2f67258da15a8" },
            new TestVector () { n=37, key="0102030405060708", offset=  16, output="8263efdb45c4a18684ef87e6b19e5b09" },
            new TestVector () { n=38, key="0102030405060708", offset= 240, output="9636ebc9841926f4f7d1f362bddf6e18" },
            new TestVector () { n=39, key="0102030405060708", offset= 256, output="d0a990ff2c05fef5b90373c9ff4b870a" },
            new TestVector () { n=40, key="0102030405060708", offset= 496, output="73239f1db7f41d80b643c0c52518ec63" },
            new TestVector () { n=41, key="0102030405060708", offset= 512, output="163b319923a6bdb4527c626126703c0f" },
            new TestVector () { n=42, key="0102030405060708", offset= 752, output="49d6c8af0f97144a87df21d91472f966" },
            new TestVector () { n=43, key="0102030405060708", offset= 768, output="44173a103b6616c5d5ad1cee40c863d0" },
            new TestVector () { n=44, key="0102030405060708", offset=1008, output="273c9c4b27f322e4e716ef53a47de7a4" },
            new TestVector () { n=45, key="0102030405060708", offset=1024, output="c6d0e7b226259fa9023490b26167ad1d" },
            new TestVector () { n=46, key="0102030405060708", offset=1520, output="1fe8986713f07c3d9ae1c163ff8cf9d3" },
            new TestVector () { n=47, key="0102030405060708", offset=1536, output="8369e1a965610be887fbd0c79162aafb" },
            new TestVector () { n=48, key="0102030405060708", offset=2032, output="0a0127abb44484b9fbef5abcae1b579f" },
            new TestVector () { n=49, key="0102030405060708", offset=2048, output="c2cdadc6402e8ee866e1f37bdb47e42c" },
            new TestVector () { n=50, key="0102030405060708", offset=3056, output="26b51ea37df8e1d6f76fc3b66a7429b3" },
            new TestVector () { n=51, key="0102030405060708", offset=3072, output="bc7683205d4f443dc1f29dda3315c87b" },
            new TestVector () { n=52, key="0102030405060708", offset=4080, output="d5fa5a3469d29aaaf83d23589db8c85b" },
            new TestVector () { n=53, key="0102030405060708", offset=4096, output="3fb46e2c8f0f068edce8cdcd7dfc5862" },
            new TestVector () { n=54, key="0102030405060708090a", offset=   0, output="ede3b04643e586cc907dc21851709902" },
            new TestVector () { n=55, key="0102030405060708090a", offset=  16, output="03516ba78f413beb223aa5d4d2df6711" },
            new TestVector () { n=56, key="0102030405060708090a", offset= 240, output="3cfd6cb58ee0fdde640176ad0000044d" },
            new TestVector () { n=57, key="0102030405060708090a", offset= 256, output="48532b21fb6079c9114c0ffd9c04a1ad" },
            new TestVector () { n=58, key="0102030405060708090a", offset= 496, output="3e8cea98017109979084b1ef92f99d86" },
            new TestVector () { n=59, key="0102030405060708090a", offset= 512, output="e20fb49bdb337ee48b8d8dc0f4afeffe" },
            new TestVector () { n=60, key="0102030405060708090a", offset= 752, output="5c2521eacd7966f15e056544bea0d315" },
            new TestVector () { n=61, key="0102030405060708090a", offset= 768, output="e067a7031931a246a6c3875d2f678acb" },
            new TestVector () { n=62, key="0102030405060708090a", offset=1008, output="a64f70af88ae56b6f87581c0e23e6b08" },
            new TestVector () { n=63, key="0102030405060708090a", offset=1024, output="f449031de312814ec6f319291f4a0516" },
            new TestVector () { n=64, key="0102030405060708090a", offset=1520, output="bdae85924b3cb1d0a2e33a30c6d79599" },
            new TestVector () { n=65, key="0102030405060708090a", offset=1536, output="8a0feddbac865a09bcd127fb562ed60a" },
            new TestVector () { n=66, key="0102030405060708090a", offset=2032, output="b55a0a5b51a12a8be34899c3e047511a" },
            new TestVector () { n=67, key="0102030405060708090a", offset=2048, output="d9a09cea3ce75fe39698070317a71339" },
            new TestVector () { n=68, key="0102030405060708090a", offset=3056, output="552225ed1177f44584ac8cfa6c4eb5fc" },
            new TestVector () { n=69, key="0102030405060708090a", offset=3072, output="7e82cbabfc95381b080998442129c2f8" },
            new TestVector () { n=70, key="0102030405060708090a", offset=4080, output="1f135ed14ce60a91369d2322bef25e3c" },
            new TestVector () { n=71, key="0102030405060708090a", offset=4096, output="08b6be45124a43e2eb77953f84dc8553" },
            new TestVector () { n=72, key="0102030405060708090a0b0c0d0e0f10", offset=   0, output="9ac7cc9a609d1ef7b2932899cde41b97" },
            new TestVector () { n=73, key="0102030405060708090a0b0c0d0e0f10", offset=  16, output="5248c4959014126a6e8a84f11d1a9e1c" },
            new TestVector () { n=74, key="0102030405060708090a0b0c0d0e0f10", offset= 240, output="065902e4b620f6cc36c8589f66432f2b" },
            new TestVector () { n=75, key="0102030405060708090a0b0c0d0e0f10", offset= 256, output="d39d566bc6bce3010768151549f3873f" },
            new TestVector () { n=76, key="0102030405060708090a0b0c0d0e0f10", offset= 496, output="b6d1e6c4a5e4771cad79538df295fb11" },
            new TestVector () { n=77, key="0102030405060708090a0b0c0d0e0f10", offset= 512, output="c68c1d5c559a974123df1dbc52a43b89" },
            new TestVector () { n=78, key="0102030405060708090a0b0c0d0e0f10", offset= 752, output="c5ecf88de897fd57fed301701b82a259" },
            new TestVector () { n=79, key="0102030405060708090a0b0c0d0e0f10", offset= 768, output="eccbe13de1fcc91c11a0b26c0bc8fa4d" },
            new TestVector () { n=80, key="0102030405060708090a0b0c0d0e0f10", offset=1008, output="e7a72574f8782ae26aabcf9ebcd66065" },
            new TestVector () { n=81, key="0102030405060708090a0b0c0d0e0f10", offset=1024, output="bdf0324e6083dcc6d3cedd3ca8c53c16" },
            new TestVector () { n=82, key="0102030405060708090a0b0c0d0e0f10", offset=1520, output="b40110c4190b5622a96116b0017ed297" },
            new TestVector () { n=83, key="0102030405060708090a0b0c0d0e0f10", offset=1536, output="ffa0b514647ec04f6306b892ae661181" },
            new TestVector () { n=84, key="0102030405060708090a0b0c0d0e0f10", offset=2032, output="d03d1bc03cd33d70dff9fa5d71963ebd" },
            new TestVector () { n=85, key="0102030405060708090a0b0c0d0e0f10", offset=2048, output="8a44126411eaa78bd51e8d87a8879bf5" },
            new TestVector () { n=86, key="0102030405060708090a0b0c0d0e0f10", offset=3056, output="fabeb76028ade2d0e48722e46c4615a3" },
            new TestVector () { n=87, key="0102030405060708090a0b0c0d0e0f10", offset=3072, output="c05d88abd50357f935a63c59ee537623" },
            new TestVector () { n=88, key="0102030405060708090a0b0c0d0e0f10", offset=4080, output="ff38265c1642c1abe8d3c2fe5e572bf8" },
            new TestVector () { n=89, key="0102030405060708090a0b0c0d0e0f10", offset=4096, output="a36a4c301ae8ac13610ccbc12256cacc" },
            new TestVector () { n=90, key="0102030405060708090a0b0c0d0e0f101112131415161718", offset=   0, output="0595e57fe5f0bb3c706edac8a4b2db11" },
            new TestVector () { n=91, key="0102030405060708090a0b0c0d0e0f101112131415161718", offset=  16, output="dfde31344a1af769c74f070aee9e2326" },
            new TestVector () { n=92, key="0102030405060708090a0b0c0d0e0f101112131415161718", offset= 240, output="b06b9b1e195d13d8f4a7995c4553ac05" },
            new TestVector () { n=93, key="0102030405060708090a0b0c0d0e0f101112131415161718", offset= 256, output="6bd2378ec341c9a42f37ba79f88a32ff" },
            new TestVector () { n=94, key="0102030405060708090a0b0c0d0e0f101112131415161718", offset= 496, output="e70bce1df7645adb5d2c4130215c3522" },
            new TestVector () { n=95, key="0102030405060708090a0b0c0d0e0f101112131415161718", offset= 512, output="9a5730c7fcb4c9af51ffda89c7f1ad22" },
            new TestVector () { n=96, key="0102030405060708090a0b0c0d0e0f101112131415161718", offset= 752, output="0485055fd4f6f0d963ef5ab9a5476982" },
            new TestVector () { n=97, key="0102030405060708090a0b0c0d0e0f101112131415161718", offset= 768, output="591fc66bcda10e452b03d4551f6b62ac" },
            new TestVector () { n=98, key="0102030405060708090a0b0c0d0e0f101112131415161718", offset=1008, output="2753cc83988afa3e1688a1d3b42c9a02" },
            new TestVector () { n=99, key="0102030405060708090a0b0c0d0e0f101112131415161718", offset=1024, output="93610d523d1d3f0062b3c2a3bbc7c7f0" },
            new TestVector () { n=100, key="0102030405060708090a0b0c0d0e0f101112131415161718", offset=1520, output="96c248610aadedfeaf8978c03de8205a" },
            new TestVector () { n=101, key="0102030405060708090a0b0c0d0e0f101112131415161718", offset=1536, output="0e317b3d1c73b9e9a4688f296d133a19" },
            new TestVector () { n=102, key="0102030405060708090a0b0c0d0e0f101112131415161718", offset=2032, output="bdf0e6c3cca5b5b9d533b69c56ada120" },
            new TestVector () { n=103, key="0102030405060708090a0b0c0d0e0f101112131415161718", offset=2048, output="88a218b6e2ece1e6246d44c759d19b10" },
            new TestVector () { n=104, key="0102030405060708090a0b0c0d0e0f101112131415161718", offset=3056, output="6866397e95c140534f94263421006e40" },
            new TestVector () { n=105, key="0102030405060708090a0b0c0d0e0f101112131415161718", offset=3072, output="32cb0a1e9542c6b3b8b398abc3b0f1d5" },
            new TestVector () { n=106, key="0102030405060708090a0b0c0d0e0f101112131415161718", offset=4080, output="29a0b8aed54a132324c62e423f54b4c8" },
            new TestVector () { n=107, key="0102030405060708090a0b0c0d0e0f101112131415161718", offset=4096, output="3cb0f3b5020a98b82af9fe154484a168" },
            new TestVector () { n=108, key="0102030405060708090a0b0c0d0e0f101112131415161718191a1b1c1d1e1f20", offset=   0, output="eaa6bd25880bf93d3f5d1e4ca2611d91" },
            new TestVector () { n=109, key="0102030405060708090a0b0c0d0e0f101112131415161718191a1b1c1d1e1f20", offset=  16, output="cfa45c9f7e714b54bdfa80027cb14380" },
            new TestVector () { n=110, key="0102030405060708090a0b0c0d0e0f101112131415161718191a1b1c1d1e1f20", offset= 240, output="114ae344ded71b35f2e60febad727fd8" },
            new TestVector () { n=111, key="0102030405060708090a0b0c0d0e0f101112131415161718191a1b1c1d1e1f20", offset= 256, output="02e1e7056b0f623900496422943e97b6" },
            new TestVector () { n=112, key="0102030405060708090a0b0c0d0e0f101112131415161718191a1b1c1d1e1f20", offset= 496, output="91cb93c787964e10d9527d999c6f936b" },
            new TestVector () { n=113, key="0102030405060708090a0b0c0d0e0f101112131415161718191a1b1c1d1e1f20", offset= 512, output="49b18b42f8e8367cbeb5ef104ba1c7cd" },
            new TestVector () { n=114, key="0102030405060708090a0b0c0d0e0f101112131415161718191a1b1c1d1e1f20", offset= 752, output="87084b3ba700bade955610672745b374" },
            new TestVector () { n=115, key="0102030405060708090a0b0c0d0e0f101112131415161718191a1b1c1d1e1f20", offset= 768, output="e7a7b9e9ec540d5ff43bdb12792d1b35" },
            new TestVector () { n=116, key="0102030405060708090a0b0c0d0e0f101112131415161718191a1b1c1d1e1f20", offset=1008, output="c799b596738f6b018c76c74b1759bd90" },
            new TestVector () { n=117, key="0102030405060708090a0b0c0d0e0f101112131415161718191a1b1c1d1e1f20", offset=1024, output="7fec5bfd9f9b89ce6548309092d7e958" },
            new TestVector () { n=118, key="0102030405060708090a0b0c0d0e0f101112131415161718191a1b1c1d1e1f20", offset=1520, output="40f250b26d1f096a4afd4c340a588815" },
            new TestVector () { n=119, key="0102030405060708090a0b0c0d0e0f101112131415161718191a1b1c1d1e1f20", offset=1536, output="3e34135c79db010200767651cf263073" },
            new TestVector () { n=120, key="0102030405060708090a0b0c0d0e0f101112131415161718191a1b1c1d1e1f20", offset=2032, output="f656abccf88dd827027b2ce917d464ec" },
            new TestVector () { n=121, key="0102030405060708090a0b0c0d0e0f101112131415161718191a1b1c1d1e1f20", offset=2048, output="18b62503bfbc077fbabb98f20d98ab34" },
            new TestVector () { n=122, key="0102030405060708090a0b0c0d0e0f101112131415161718191a1b1c1d1e1f20", offset=3056, output="8aed95ee5b0dcbfbef4eb21d3a3f52f9" },
            new TestVector () { n=123, key="0102030405060708090a0b0c0d0e0f101112131415161718191a1b1c1d1e1f20", offset=3072, output="625a1ab00ee39a5327346bddb01a9c18" },
            new TestVector () { n=124, key="0102030405060708090a0b0c0d0e0f101112131415161718191a1b1c1d1e1f20", offset=4080, output="a13a7c79c7e119b5ab0296ab28c300b9" },
            new TestVector () { n=125, key="0102030405060708090a0b0c0d0e0f101112131415161718191a1b1c1d1e1f20", offset=4096, output="f3e4c0a2e02d1d01f7f0a74618af2b48" },
            new TestVector () { n=126, key="833222772a", offset=   0, output="80ad97bdc973df8a2e879e92a497efda" },
            new TestVector () { n=127, key="833222772a", offset=  16, output="20f060c2f2e5126501d3d4fea10d5fc0" },
            new TestVector () { n=128, key="833222772a", offset= 240, output="faa148e99046181fec6b2085f3b20ed9" },
            new TestVector () { n=129, key="833222772a", offset= 256, output="f0daf5bab3d596839857846f73fbfe5a" },
            new TestVector () { n=130, key="833222772a", offset= 496, output="1c7e2fc4639232fe297584b296996bc8" },
            new TestVector () { n=131, key="833222772a", offset= 512, output="3db9b249406cc8edffac55ccd322ba12" },
            new TestVector () { n=132, key="833222772a", offset= 752, output="e4f9f7e0066154bbd125b745569bc897" },
            new TestVector () { n=133, key="833222772a", offset= 768, output="75d5ef262b44c41a9cf63ae14568e1b9" },
            new TestVector () { n=134, key="833222772a", offset=1008, output="6da453dbf81e82334a3d8866cb50a1e3" },
            new TestVector () { n=135, key="833222772a", offset=1024, output="7828d074119cab5c22b294d7a9bfa0bb" },
            new TestVector () { n=136, key="833222772a", offset=1520, output="adb89cea9a15fbe617295bd04b8ca05c" },
            new TestVector () { n=137, key="833222772a", offset=1536, output="6251d87fd4aaae9a7e4ad5c217d3f300" },
            new TestVector () { n=138, key="833222772a", offset=2032, output="e7119bd6dd9b22afe8f89585432881e2" },
            new TestVector () { n=139, key="833222772a", offset=2048, output="785b60fd7ec4e9fcb6545f350d660fab" },
            new TestVector () { n=140, key="833222772a", offset=3056, output="afecc037fdb7b0838eb3d70bcd268382" },
            new TestVector () { n=141, key="833222772a", offset=3072, output="dbc1a7b49d57358cc9fa6d61d73b7cf0" },
            new TestVector () { n=142, key="833222772a", offset=4080, output="6349d126a37afcba89794f9804914fdc" },
            new TestVector () { n=143, key="833222772a", offset=4096, output="bf42c3018c2f7c66bfde524975768115" },
            new TestVector () { n=144, key="1910833222772a", offset=   0, output="bc9222dbd3274d8fc66d14ccbda6690b" },
            new TestVector () { n=145, key="1910833222772a", offset=  16, output="7ae627410c9a2be693df5bb7485a63e3" },
            new TestVector () { n=146, key="1910833222772a", offset= 240, output="3f0931aa03defb300f060103826f2a64" },
            new TestVector () { n=147, key="1910833222772a", offset= 256, output="beaa9ec8d59bb68129f3027c96361181" },
            new TestVector () { n=148, key="1910833222772a", offset= 496, output="74e04db46d28648d7dee8a0064b06cfe" },
            new TestVector () { n=149, key="1910833222772a", offset= 512, output="9b5e81c62fe023c55be42f87bbf932b8" },
            new TestVector () { n=150, key="1910833222772a", offset= 752, output="ce178fc1826efecbc182f57999a46140" },
            new TestVector () { n=151, key="1910833222772a", offset= 768, output="8bdf55cd55061c06dba6be11de4a578a" },
            new TestVector () { n=152, key="1910833222772a", offset=1008, output="626f5f4dce652501f3087d39c92cc349" },
            new TestVector () { n=153, key="1910833222772a", offset=1024, output="42daac6a8f9ab9a7fd137c6037825682" },
            new TestVector () { n=154, key="1910833222772a", offset=1520, output="cc03fdb79192a207312f53f5d4dc33d9" },
            new TestVector () { n=155, key="1910833222772a", offset=1536, output="f70f14122a1c98a3155d28b8a0a8a41d" },
            new TestVector () { n=156, key="1910833222772a", offset=2032, output="2a3a307ab2708a9c00fe0b42f9c2d6a1" },
            new TestVector () { n=157, key="1910833222772a", offset=2048, output="862617627d2261eab0b1246597ca0ae9" },
            new TestVector () { n=158, key="1910833222772a", offset=3056, output="55f877ce4f2e1ddbbf8e13e2cde0fdc8" },
            new TestVector () { n=159, key="1910833222772a", offset=3072, output="1b1556cb935f173337705fbb5d501fc1" },
            new TestVector () { n=160, key="1910833222772a", offset=4080, output="ecd0e96602be7f8d5092816cccf2c2e9" },
            new TestVector () { n=161, key="1910833222772a", offset=4096, output="027881fab4993a1c262024a94fff3f61" },
            new TestVector () { n=162, key="641910833222772a", offset=   0, output="bbf609de9413172d07660cb680716926" },
            new TestVector () { n=163, key="641910833222772a", offset=  16, output="46101a6dab43115d6c522b4fe93604a9" },
            new TestVector () { n=164, key="641910833222772a", offset= 240, output="cbe1fff21c96f3eef61e8fe0542cbdf0" },
            new TestVector () { n=165, key="641910833222772a", offset= 256, output="347938bffa4009c512cfb4034b0dd1a7" },
            new TestVector () { n=166, key="641910833222772a", offset= 496, output="7867a786d00a7147904d76ddf1e520e3" },
            new TestVector () { n=167, key="641910833222772a", offset= 512, output="8d3e9e1caefcccb3fbf8d18f64120b32" },
            new TestVector () { n=168, key="641910833222772a", offset= 752, output="942337f8fd76f0fae8c52d7954810672" },
            new TestVector () { n=169, key="641910833222772a", offset= 768, output="b8548c10f51667f6e60e182fa19b30f7" },
            new TestVector () { n=170, key="641910833222772a", offset=1008, output="0211c7c6190c9efd1237c34c8f2e06c4" },
            new TestVector () { n=171, key="641910833222772a", offset=1024, output="bda64f65276d2aacb8f90212203a808e" },
            new TestVector () { n=172, key="641910833222772a", offset=1520, output="bd3820f732ffb53ec193e79d33e27c73" },
            new TestVector () { n=173, key="641910833222772a", offset=1536, output="d0168616861907d482e36cdac8cf5749" },
            new TestVector () { n=174, key="641910833222772a", offset=2032, output="97b0f0f224b2d2317114808fb03af7a0" },
            new TestVector () { n=175, key="641910833222772a", offset=2048, output="e59616e469787939a063ceea9af956d1" },
            new TestVector () { n=176, key="641910833222772a", offset=3056, output="c47e0dc1660919c11101208f9e69aa1f" },
            new TestVector () { n=177, key="641910833222772a", offset=3072, output="5ae4f12896b8379a2aad89b5b553d6b0" },
            new TestVector () { n=178, key="641910833222772a", offset=4080, output="6b6b098d0c293bc2993d80bf0518b6d9" },
            new TestVector () { n=179, key="641910833222772a", offset=4096, output="8170cc3ccd92a698621b939dd38fe7b9" },
            new TestVector () { n=180, key="8b37641910833222772a", offset=   0, output="ab65c26eddb287600db2fda10d1e605c" },
            new TestVector () { n=181, key="8b37641910833222772a", offset=  16, output="bb759010c29658f2c72d93a2d16d2930" },
            new TestVector () { n=182, key="8b37641910833222772a", offset= 240, output="b901e8036ed1c383cd3c4c4dd0a6ab05" },
            new TestVector () { n=183, key="8b37641910833222772a", offset= 256, output="3d25ce4922924c55f064943353d78a6c" },
            new TestVector () { n=184, key="8b37641910833222772a", offset= 496, output="12c1aa44bbf87e75e611f69b2c38f49b" },
            new TestVector () { n=185, key="8b37641910833222772a", offset= 512, output="28f2b3434b65c09877470044c6ea170d" },
            new TestVector () { n=186, key="8b37641910833222772a", offset= 752, output="bd9ef822de5288196134cf8af7839304" },
            new TestVector () { n=187, key="8b37641910833222772a", offset= 768, output="67559c23f052158470a296f725735a32" },
            new TestVector () { n=188, key="8b37641910833222772a", offset=1008, output="8bab26fbc2c12b0f13e2ab185eabf241" },
            new TestVector () { n=189, key="8b37641910833222772a", offset=1024, output="31185a6d696f0cfa9b42808b38e132a2" },
            new TestVector () { n=190, key="8b37641910833222772a", offset=1520, output="564d3dae183c5234c8af1e51061c44b5" },
            new TestVector () { n=191, key="8b37641910833222772a", offset=1536, output="3c0778a7b5f72d3c23a3135c7d67b9f4" },
            new TestVector () { n=192, key="8b37641910833222772a", offset=2032, output="f34369890fcf16fb517dcaae4463b2dd" },
            new TestVector () { n=193, key="8b37641910833222772a", offset=2048, output="02f31c81e8200731b899b028e791bfa7" },
            new TestVector () { n=194, key="8b37641910833222772a", offset=3056, output="72da646283228c14300853701795616f" },
            new TestVector () { n=195, key="8b37641910833222772a", offset=3072, output="4e0a8c6f7934a788e2265e81d6d0c8f4" },
            new TestVector () { n=196, key="8b37641910833222772a", offset=4080, output="438dd5eafea0111b6f36b4b938da2a68" },
            new TestVector () { n=197, key="8b37641910833222772a", offset=4096, output="5f6bfc73815874d97100f086979357d8" },
            new TestVector () { n=198, key="ebb46227c6cc8b37641910833222772a", offset=   0, output="720c94b63edf44e131d950ca211a5a30" },
            new TestVector () { n=199, key="ebb46227c6cc8b37641910833222772a", offset=  16, output="c366fdeacf9ca80436be7c358424d20b" },
            new TestVector () { n=200, key="ebb46227c6cc8b37641910833222772a", offset= 240, output="b3394a40aabf75cba42282ef25a0059f" },
            new TestVector () { n=201, key="ebb46227c6cc8b37641910833222772a", offset= 256, output="4847d81da4942dbc249defc48c922b9f" },
            new TestVector () { n=202, key="ebb46227c6cc8b37641910833222772a", offset= 496, output="08128c469f275342adda202b2b58da95" },
            new TestVector () { n=203, key="ebb46227c6cc8b37641910833222772a", offset= 512, output="970dacef40ad98723bac5d6955b81761" },
            new TestVector () { n=204, key="ebb46227c6cc8b37641910833222772a", offset= 752, output="3cb89993b07b0ced93de13d2a11013ac" },
            new TestVector () { n=205, key="ebb46227c6cc8b37641910833222772a", offset= 768, output="ef2d676f1545c2c13dc680a02f4adbfe" },
            new TestVector () { n=206, key="ebb46227c6cc8b37641910833222772a", offset=1008, output="b60595514f24bc9fe522a6cad7393644" },
            new TestVector () { n=207, key="ebb46227c6cc8b37641910833222772a", offset=1024, output="b515a8c5011754f59003058bdb81514e" },
            new TestVector () { n=208, key="ebb46227c6cc8b37641910833222772a", offset=1520, output="3c70047e8cbc038e3b9820db601da495" },
            new TestVector () { n=209, key="ebb46227c6cc8b37641910833222772a", offset=1536, output="1175da6ee756de46a53e2b075660b770" },
            new TestVector () { n=210, key="ebb46227c6cc8b37641910833222772a", offset=2032, output="00a542bba02111cc2c65b38ebdba587e" },
            new TestVector () { n=211, key="ebb46227c6cc8b37641910833222772a", offset=2048, output="5865fdbb5b48064104e830b380f2aede" },
            new TestVector () { n=212, key="ebb46227c6cc8b37641910833222772a", offset=3056, output="34b21ad2ad44e999db2d7f0863f0d9b6" },
            new TestVector () { n=213, key="ebb46227c6cc8b37641910833222772a", offset=3072, output="84a9218fc36e8a5f2ccfbeae53a27d25" },
            new TestVector () { n=214, key="ebb46227c6cc8b37641910833222772a", offset=4080, output="a2221a11b833ccb498a59540f0545f4a" },
            new TestVector () { n=215, key="ebb46227c6cc8b37641910833222772a", offset=4096, output="5bbeb4787d59e5373fdbea6c6f75c29b" },
            new TestVector () { n=216, key="c109163908ebe51debb46227c6cc8b37641910833222772a", offset=   0, output="54b64e6b5a20b5e2ec84593dc7989da7" },
            new TestVector () { n=217, key="c109163908ebe51debb46227c6cc8b37641910833222772a", offset=  16, output="c135eee237a85465ff97dc03924f45ce" },
            new TestVector () { n=218, key="c109163908ebe51debb46227c6cc8b37641910833222772a", offset= 240, output="cfcc922fb4a14ab45d6175aabbf2d201" },
            new TestVector () { n=219, key="c109163908ebe51debb46227c6cc8b37641910833222772a", offset= 256, output="837b87e2a446ad0ef798acd02b94124f" },
            new TestVector () { n=220, key="c109163908ebe51debb46227c6cc8b37641910833222772a", offset= 496, output="17a6dbd664926a0636b3f4c37a4f4694" },
            new TestVector () { n=221, key="c109163908ebe51debb46227c6cc8b37641910833222772a", offset= 512, output="4a5f9f26aeeed4d4a25f632d305233d9" },
            new TestVector () { n=222, key="c109163908ebe51debb46227c6cc8b37641910833222772a", offset= 752, output="80a3d01ef00c8e9a4209c17f4eeb358c" },
            new TestVector () { n=223, key="c109163908ebe51debb46227c6cc8b37641910833222772a", offset= 768, output="d15e7d5ffaaabc0207bf200a117793a2" },
            new TestVector () { n=224, key="c109163908ebe51debb46227c6cc8b37641910833222772a", offset=1008, output="349682bf588eaa52d0aa1560346aeafa" },
            new TestVector () { n=225, key="c109163908ebe51debb46227c6cc8b37641910833222772a", offset=1024, output="f5854cdb76c889e3ad63354e5f7275e3" },
            new TestVector () { n=226, key="c109163908ebe51debb46227c6cc8b37641910833222772a", offset=1520, output="532c7ceccb39df3236318405a4b1279c" },
            new TestVector () { n=227, key="c109163908ebe51debb46227c6cc8b37641910833222772a", offset=1536, output="baefe6d9ceb651842260e0d1e05e3b90" },
            new TestVector () { n=228, key="c109163908ebe51debb46227c6cc8b37641910833222772a", offset=2032, output="e82d8c6db54e3c633f581c952ba04207" },
            new TestVector () { n=229, key="c109163908ebe51debb46227c6cc8b37641910833222772a", offset=2048, output="4b16e50abd381bd70900a9cd9a62cb23" },
            new TestVector () { n=230, key="c109163908ebe51debb46227c6cc8b37641910833222772a", offset=3056, output="3682ee33bd148bd9f58656cd8f30d9fb" },
            new TestVector () { n=231, key="c109163908ebe51debb46227c6cc8b37641910833222772a", offset=3072, output="1e5a0b8475045d9b20b2628624edfd9e" },
            new TestVector () { n=232, key="c109163908ebe51debb46227c6cc8b37641910833222772a", offset=4080, output="63edd684fb826282fe528f9c0e9237bc" },
            new TestVector () { n=233, key="c109163908ebe51debb46227c6cc8b37641910833222772a", offset=4096, output="e4dd2e98d6960fae0b43545456743391" },
            new TestVector () { n=234, key="1ada31d5cf688221c109163908ebe51debb46227c6cc8b37641910833222772a", offset=   0, output="dd5bcb0018e922d494759d7c395d02d3" },
            new TestVector () { n=235, key="1ada31d5cf688221c109163908ebe51debb46227c6cc8b37641910833222772a", offset=  16, output="c8446f8f77abf737685353eb89a1c9eb" },
            new TestVector () { n=236, key="1ada31d5cf688221c109163908ebe51debb46227c6cc8b37641910833222772a", offset= 240, output="af3e30f9c095045938151575c3fb9098" },
            new TestVector () { n=237, key="1ada31d5cf688221c109163908ebe51debb46227c6cc8b37641910833222772a", offset= 256, output="f8cb6274db99b80b1d2012a98ed48f0e" },
            new TestVector () { n=238, key="1ada31d5cf688221c109163908ebe51debb46227c6cc8b37641910833222772a", offset= 496, output="25c3005a1cb85de076259839ab7198ab" },
            new TestVector () { n=239, key="1ada31d5cf688221c109163908ebe51debb46227c6cc8b37641910833222772a", offset= 512, output="9dcbc183e8cb994b727b75be3180769c" },
            new TestVector () { n=240, key="1ada31d5cf688221c109163908ebe51debb46227c6cc8b37641910833222772a", offset= 752, output="a1d3078dfa9169503ed9d4491dee4eb2" },
            new TestVector () { n=241, key="1ada31d5cf688221c109163908ebe51debb46227c6cc8b37641910833222772a", offset= 768, output="8514a5495858096f596e4bcd66b10665" },
            new TestVector () { n=242, key="1ada31d5cf688221c109163908ebe51debb46227c6cc8b37641910833222772a", offset=1008, output="5f40d59ec1b03b33738efa60b2255d31" },
            new TestVector () { n=243, key="1ada31d5cf688221c109163908ebe51debb46227c6cc8b37641910833222772a", offset=1024, output="3477c7f764a41baceff90bf14f92b7cc" },
            new TestVector () { n=244, key="1ada31d5cf688221c109163908ebe51debb46227c6cc8b37641910833222772a", offset=1520, output="ac4e95368d99b9eb78b8da8f81ffa795" },
            new TestVector () { n=245, key="1ada31d5cf688221c109163908ebe51debb46227c6cc8b37641910833222772a", offset=1536, output="8c3c13f8c2388bb73f38576e65b7c446" },
            new TestVector () { n=246, key="1ada31d5cf688221c109163908ebe51debb46227c6cc8b37641910833222772a", offset=2032, output="13c4b9c1dfb66579eddd8a280b9f7316" },
            new TestVector () { n=247, key="1ada31d5cf688221c109163908ebe51debb46227c6cc8b37641910833222772a", offset=2048, output="ddd27820550126698efaadc64b64f66e" },
            new TestVector () { n=248, key="1ada31d5cf688221c109163908ebe51debb46227c6cc8b37641910833222772a", offset=3056, output="f08f2e66d28ed143f3a237cf9de73559" },
            new TestVector () { n=249, key="1ada31d5cf688221c109163908ebe51debb46227c6cc8b37641910833222772a", offset=3072, output="9ea36c525531b880ba124334f57b0b70" },
            new TestVector () { n=250, key="1ada31d5cf688221c109163908ebe51debb46227c6cc8b37641910833222772a", offset=4080, output="d5a39e3dfcc50280bac4a6b5aa0dca7d" },
            new TestVector () { n=251, key="1ada31d5cf688221c109163908ebe51debb46227c6cc8b37641910833222772a", offset=4096, output="370b1c1fe655916d97fd0d47ca1d72b8" }
        };

    }
}