/*
   Copyright 2008 Timo Eckhardt, University of Siegen

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/

using CrypTool.PluginBase.Miscellaneous;
using System;
using System.Numerics;

namespace Primes.WpfControls.NumberTheory.NumberTheoryFunctions
{
    public class Rho : BaseNTFunction
    {
        public Rho()
            : base()
        {
        }

        protected override void DoExecute()
        {
            FireOnStart();

            for (BigInteger x = m_From; x <= m_To; x++)
            {
                BigInteger sum = 0;
                Array.ForEach(x.Divisors().ToArray(), delegate (BigInteger i) { sum += i; });

                FireOnMessage(this, x, sum.ToString());
            }

            FireOnStop();
        }

        public override string Description => m_ResourceManager.GetString(BaseNTFunction.rho);
    }
}