﻿using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Tests.TemplateAndPluginTests
{
    [TestClass]
    public class LAMBDA1Test
    {
        private static readonly int ENCRYPTION = 0;
        private static readonly int DECRYPTION = 1;

        private static void RunTest(TestCase[] cases, PluginTestScenario scenario, bool decrypt)
        {
            object[] inputs, outputs;
            foreach (TestCase testCase in cases)
            {
                /*
                 * Encryption
                 */
                inputs = new object[]
                {
                    testCase.input,
                    testCase.key,
                    testCase.iV,
                    ENCRYPTION
                };
                outputs = scenario.GetOutputs(inputs);
                AssertByteEqual((byte[])outputs[0], testCase.expected);

                if (decrypt)
                {
                    /*
                     * Decryption again
                     */
                    inputs = new object[]
                    {
                    outputs[0],
                    testCase.key,
                    testCase.iV,
                    DECRYPTION
                    };
                    outputs = scenario.GetOutputs(inputs);
                    AssertByteEqual((byte[])outputs[0], testCase.input);
                }
            }
        }

        [TestMethod]
        public void LAMBDA1TestOperationMode()
        {
            CrypTool.PluginBase.ICrypComponent pluginInstance = TestHelpers.GetPluginInstance("LAMBDA1");
            PluginTestScenario scenario = new PluginTestScenario(pluginInstance, new[] { "InputData", "InputKey", "InputIV", ".Mode" }, new[] { "OutputData" });
            RunTest(testCasesOperationMode, scenario, true);
        }

        [TestMethod]
        public void LAMBDA1TestSingleBlocks()
        {
            CrypTool.PluginBase.ICrypComponent pluginInstance = TestHelpers.GetPluginInstance("LAMBDA1");
            PluginTestScenario scenario = new PluginTestScenario(pluginInstance, new[] { "InputData", "InputKey", "InputIV", ".Mode" }, new[] { "OutputData" });
            RunTest(testCasesSingleBlock, scenario, false);
        }

        private struct TestCase
        {
            public byte[] input, key, iV, expected;
        }

        #region TestCasesOperationMode
        private static void AssertByteEqual(byte[] left, byte[] right)
        {
            Assert.AreEqual(left.Length, right.Length);
            for (int i = 0; i < left.Length; ++i)
            {
                Assert.AreEqual(left[i], right[i]);
            }
        }

        private readonly TestCase[] testCasesOperationMode = new TestCase[] {
            new TestCase() {input = new byte[]
                            {
                                 0x70, 0x64, 0x04, 0x24, 0x12, 0x84, 0x70, 0x16,
                                 0x83, 0x40, 0x13, 0xC4, 0xE2, 0xAA, 0x84, 0xBD,
                                 0x91, 0x92, 0x24, 0x41, 0xCC, 0x40, 0x13, 0x32,
                                 0x10, 0x54, 0x01, 0x49, 0x24, 0x01, 0x10, 0xE1,
                                 0x85, 0x11, 0xA2, 0x83, 0x59, 0x41, 0x8F, 0x13,
                                 0xD1, 0x19, 0x19, 0x22, 0x5E, 0x04, 0xA0, 0xCA,
                                 0x64, 0x40, 0x46, 0x40, 0x73, 0x1A, 0x10, 0x31,
                                 0xCD, 0x10, 0x90, 0x4A, 0x10, 0x55, 0x45, 0x40,
                                 0x17, 0x05, 0x12, 0x6E, 0x04, 0x04, 0x63, 0x01,
                                 0x10, 0xC0, 0x47, 0x04, 0x44, 0xD8, 0x28, 0xF1,
                                 0x50, 0x0D, 0x01, 0x98, 0x31, 0xA0, 0x4C, 0x04,
                                 0xA0, 0xD0, 0x19, 0x83, 0x04, 0x34, 0x70, 0x4A,
                                 0x10, 0x91, 0x81, 0x10, 0x13, 0x94, 0x41, 0x10,
                                 0x46, 0x42, 0x31, 0x46, 0x70, 0x74, 0x83, 0x40,
                                 0x66, 0x0C, 0x11, 0xE6, 0x0A, 0xF0, 0x47, 0x01,
                                 0x68, 0x34, 0x01, 0x3C, 0x41, 0x85, 0x40, 0x40,
                                 0x46, 0x30, 0x41, 0xCC, 0x40, 0x12, 0x8C, 0x05,
                                 0x47, 0x01, 0x30, 0x42, 0x41, 0x28, 0x41, 0xCC,
                                 0x19, 0x00, 0x49, 0x11, 0x00, 0x52, 0x04, 0xE6,
                                 0x1C, 0x10, 0x73, 0x09, 0x11, 0x31, 0x8A, 0x24,
                                 0x47, 0x98, 0x30, 0x43, 0x86, 0x14, 0x40, 0x5D,
                                 0x3D, 0x21, 0xC5, 0x19, 0xE1, 0x1E, 0x04, 0xA4,
                                 0x0A, 0x05, 0x00, 0x4C, 0xF0, 0x42, 0x47, 0x28,
                                 0xE5, 0x04, 0x24, 0x60, 0x44, 0x18, 0xC4, 0x01,
                                 0x68, 0xA0, 0xD0, 0x19, 0x83, 0x04, 0x79, 0x83,
                                 0x04, 0x15, 0x60, 0x51, 0x18, 0x14, 0x92, 0x04,
                                 0xC1, 0x16, 0x29, 0x84, 0x41, 0x14, 0x56, 0x0A,
                                 0x04, 0xC1, 0x1E, 0x60, 0xC1, 0x13, 0x04, 0x64,
                                 0x01, 0x3E, 0xC1, 0x10, 0x05, 0xD0, 0xC5, 0x10,
                                 0x63, 0x05, 0x40, 0xA1, 0xDC, 0x04, 0xC4, 0x05,
                                 0x10, 0x73, 0x09, 0x11, 0xC6, 0x10, 0x60, 0xA6,
                                 0x12, 0x0C, 0x41, 0x8C, 0x10, 0x11, 0x8C, 0x05,
                                 0xC1, 0x05, 0x40, 0x33, 0x09, 0x0C, 0xA2, 0x59,
                                 0x1C, 0x50
                            },
                            key = new byte[]
                            {
                                 0x01, 0x23, 0x45, 0x67, 0x89, 0xAB, 0xCD, 0xEF,
                                 0xFE, 0xDC, 0xBA, 0x98, 0x76, 0x54, 0x32, 0x10,
                                 0x01, 0x23, 0x45, 0x67, 0x89, 0xAB, 0xCD, 0xEF,
                                 0xFE, 0xDC, 0xBA, 0x98, 0x76, 0x54, 0x32, 0x10
                            },
                            iV = new byte[]
                            {
                                0x87, 0x87, 0x87, 0x87, 0x87, 0x87, 0x87, 0x87
                            },
                            expected = new byte[]
                            {
                                0xF7, 0xB0, 0x1C, 0xD4, 0xEE, 0xAC, 0x40, 0x6C,
                                0x62, 0xE6, 0xD2, 0x85, 0x71, 0x71, 0xF1, 0xF7,
                                0x82, 0x30, 0x40, 0xFC, 0x2C, 0x84, 0xCB, 0x2F,
                                0xC1, 0x64, 0x11, 0x92, 0x6B, 0x73, 0x25, 0x94,
                                0xA3, 0x72, 0xA8, 0x7F, 0xB7, 0x92, 0xBA, 0x16,
                                0x5C, 0xF3, 0x12, 0xDE, 0x41, 0x98, 0x74, 0x72,
                                0xD9, 0xD3, 0x1F, 0xC5, 0x81, 0x22, 0x24, 0x6D,
                                0x70, 0xE7, 0x14, 0x5F, 0x96, 0xCA, 0xC6, 0x23,
                                0x2A, 0xF5, 0xBB, 0xED, 0xF6, 0x8F, 0x0B, 0x97,
                                0x1B, 0x48, 0x61, 0xB7, 0x77, 0xA5, 0x81, 0xAF,
                                0x10, 0x31, 0x0D, 0x4A, 0x54, 0x21, 0x87, 0x44,
                                0x5A, 0x7D, 0xAD, 0xF9, 0x9D, 0xF3, 0x42, 0xA0,
                                0x99, 0x18, 0x6E, 0xF7, 0x49, 0xBF, 0x57, 0x56,
                                0x35, 0xF4, 0xDB, 0xB8, 0x13, 0xC0, 0xC0, 0x2C,
                                0x4C, 0xB6, 0xF3, 0xE0, 0x94, 0x21, 0x7B, 0x01,
                                0x13, 0xAD, 0x65, 0x9A, 0xF1, 0xBF, 0x7F, 0xC1,
                                0x59, 0x7C, 0x3A, 0x4B, 0x2D, 0xEE, 0x6F, 0x8F,
                                0x84, 0x14, 0x2D, 0x64, 0xB2, 0x26, 0x90, 0xB8,
                                0xDE, 0x3C, 0xCA, 0x23, 0xC5, 0x60, 0x04, 0xFE,
                                0x15, 0x4B, 0x32, 0x9D, 0x9F, 0x73, 0xAC, 0x07,
                                0xA9, 0x25, 0x6C, 0x93, 0xB6, 0xDC, 0x4B, 0xA9,
                                0xE0, 0xBB, 0x47, 0x86, 0xE3, 0x22, 0x12, 0x6C,
                                0xB7, 0xAE, 0xED, 0x52, 0x01, 0xD5, 0xAB, 0xA9,
                                0xA5, 0x8D, 0x4A, 0x88, 0x7B, 0x3B, 0xA4, 0x10,
                                0x44, 0xA0, 0x52, 0x51, 0x4B, 0x59, 0xF8, 0x9D,
                                0x79, 0x6F, 0x32, 0x65, 0x5F, 0x36, 0x37, 0xAB,
                                0xD9, 0x18, 0x0C, 0x2C, 0xDF, 0x98, 0xF9, 0x97,
                                0x78, 0x9F, 0x7B, 0xBF, 0x20, 0x3B, 0x02, 0x7E,
                                0x66, 0x16, 0x4F, 0x14, 0xA4, 0x16, 0x33, 0x8A,
                                0x8E, 0x34, 0x39, 0x7D, 0x94, 0x35, 0xD2, 0xF0,
                                0x76, 0x57, 0xC5, 0xE2, 0x57, 0x40, 0x97, 0x09,
                                0x6B, 0x92, 0x06, 0xCA, 0xF7, 0x1D, 0x02, 0xB8,
                                0x2F, 0xC9, 0xF4, 0x1A, 0xD4, 0xE0, 0xE8, 0x24,
                                0xE1, 0xAD, 0x57, 0xDC, 0x57, 0x5F, 0x55, 0x8B,
                            }
            },
            new TestCase() {input = new byte[]
                            {
                                0x02, 0x2A, 0x2B, 0x2A, 0x2B, 0x2A, 0x2B, 0x2A, 0x2B
                            },
                            key = new byte[]
                            {
                                 0x01, 0x23, 0x45, 0x67, 0x89, 0xAB, 0xCD, 0xEF,
                                 0xFE, 0xDC, 0xBA, 0x98, 0x76, 0x54, 0x32, 0x10,
                                 0x01, 0x23, 0x45, 0x67, 0x89, 0xAB, 0xCD, 0xEF,
                                 0xFE, 0xDC, 0xBA, 0x98, 0x76, 0x54, 0x32, 0x10
                            },
                            iV = new byte[]
                            {
                                0x87, 0x87, 0x87, 0x87, 0x78, 0x78, 0x78, 0x78
                            },
                            expected = new byte[]
                            {
                                0x02, 0xF6, 0xC1, 0xB6, 0xC2, 0xE2, 0x6D, 0x17,
                                0xE8, 0x13, 0x45, 0x63, 0x44, 0x5B, 0x07, 0xCB
                            }
            },
            new TestCase() {input = new byte[]
                            {
                                0x24, 0xCD, 0x3F, 0x88, 0x30, 0x65, 0x9C, 0x22,
                                0x51, 0x46, 0x26, 0x48, 0x41, 0xE0, 0x5d, 0x54,
                                0xF0, 0x67, 0x8D, 0x72, 0xED, 0xD9, 0xB9, 0xAA,
                            },
                            key = new byte[]
                            {
                                0x02, 0x3C, 0x67, 0x13, 0xA0, 0xA2, 0x70, 0xE9,
                                0xF3, 0x26, 0xD4, 0x96, 0x18, 0x4A, 0xEA, 0xCB,
                                0x1D, 0x9E, 0x52, 0xDF, 0x6F, 0x3F, 0xC8, 0x45,
                                0x4E, 0x0B, 0x2C, 0x01, 0x2A, 0x4D, 0x2E, 0x73,
                            },
                            iV = null,
                            expected = new byte[]
                            {
                                0xB0, 0x5B, 0xCB, 0xB1, 0x29, 0xC4, 0xDC, 0x8F,
                                0xD3, 0x0E, 0x45, 0x06, 0xB0, 0xD6, 0x38, 0xDF,
                                0xBE, 0x16, 0x72, 0xA9, 0x74, 0xD0, 0xAA, 0xD6,
                            }
            }
        };
        #endregion
        #region TestCasesSingleBlocks
        private readonly TestCase[] testCasesSingleBlock = new TestCase[]
        {
            new TestCase()
            {
                input = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 },
                key = new byte []
                {
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00
                },
                iV = new byte[] { 0x87, 0x87, 0x87, 0x87, 0x78, 0x78, 0x78, 0x78 },
                expected = new byte[] { 0x66, 0x60, 0x4A, 0x27, 0xFE, 0x8C, 0x05, 0x75 }
            },
            new TestCase()
            {
                input = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 },
                key = new byte []
                {
                    0x00, 0x00, 0xFF, 0xFF, 0x00, 0x00, 0xFF, 0xFF,
                    0x00, 0x00, 0xFF, 0xFF, 0x00, 0x00, 0xFF, 0xFF,
                    0x00, 0x00, 0xFF, 0xFF, 0x00, 0x00, 0xFF, 0xFF,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00
                },
                iV = new byte[] { 0x87, 0x87, 0x87, 0x87, 0x78, 0x78, 0x78, 0x78 },
                expected = new byte[] { 0xC3, 0x89, 0x22, 0x7B, 0xB0, 0x55, 0xF6, 0xA4 }
            },
            new TestCase()
            {
                input = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 },
                key = new byte []
                {
                    0xFF, 0xFF, 0x00, 0x00, 0xFF, 0xFF, 0x00, 0x00,
                    0xFF, 0xFF, 0x00, 0x00, 0xFF, 0xFF, 0x00, 0x00,
                    0xFF, 0xFF, 0x00, 0x00, 0xFF, 0xFF, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00, 0xFF, 0xFF, 0xFF, 0xFF
                },
                iV = new byte[] { 0x87, 0x87, 0x87, 0x87, 0x78, 0x78, 0x78, 0x78 },
                expected = new byte[] { 0x7A, 0x15, 0xF1, 0xCC, 0x6A, 0x59, 0xC2, 0x08 }
            },
            new TestCase()
            {
                input = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 },
                key = new byte []
                {
                    0x28, 0x1E, 0x51, 0x91, 0xAC, 0xEB, 0x97, 0x59,
                    0x7B, 0x31, 0xBB, 0x8B, 0xA8, 0x7F, 0x82, 0xAC,
                    0xC3, 0x31, 0xB8, 0x75, 0x49, 0xB2, 0x40, 0x04,
                    0x31, 0xFC, 0x30, 0x2E, 0xE2, 0x19, 0x65, 0xEC,
                },
                iV = new byte[] { 0x28, 0x49, 0xF5, 0x54, 0x32, 0x5E, 0xD8, 0xFA },
                expected = new byte[] { 0xDD, 0x92, 0x22, 0xC4, 0x7B, 0x6D, 0x54, 0x7A }
            },
        };
        #endregion
    }
}

