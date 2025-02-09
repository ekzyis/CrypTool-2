﻿/*
   Copyright 2011 Matthäus Wander, University of Duisburg-Essen

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

using System;

namespace CrypTool.PluginBase
{
    public enum ComponentCategory
    {
        CiphersClassic,
        CiphersModernSymmetric,
        CiphersModernAsymmetric,
        Steganography,
        HashFunctions,
        CryptanalysisSpecific,
        CryptanalysisGeneric,
        Protocols,
        ToolsBoolean,
        ToolsDataflow,
        ToolsDataInputOutput,
        ToolsRandomNumbers,
        ToolsCodes,
        ToolsMisc,
        DECRYPTProjectComponent,
        Undefined
    }

    /// <summary>
    /// This mandatory attribute is used to group CT2 components into categories.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class ComponentCategoryAttribute : Attribute
    {
        public ComponentCategory Category
        {
            get;
            private set;
        }

        public ComponentCategoryAttribute(ComponentCategory category)
        {
            Category = category;
        }
    }
}
