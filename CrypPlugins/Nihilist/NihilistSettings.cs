﻿/*                              
   Copyright 2009 Fabian Enkler

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

using CrypTool.PluginBase;
using System.ComponentModel;

namespace Nihilist
{
    internal class NihilistSettings : ISettings
    {
        private enum Actions
        {
            Encrypt,
            Decrypt
        }

        private Actions action = Actions.Encrypt;
        [ContextMenu("ActionCaption", "ActionTooltip", 0, ContextMenuControlType.ComboBox, null, new[] { "ActionList1", "ActionList2" })]
        [TaskPane("ActionCaption", "ActionTooltip", null, 0, false, ControlType.ComboBox, new[] { "ActionList1", "ActionList2" })]
        public int Action
        {
            get => (int)action;
            set
            {
                action = (Actions)value;
                OnPropertyChanged("Action");
            }
        }

        private string keyWord = string.Empty;
        [TaskPane("KeyWordCaption", "KeyWordTooltip", null, 0, false, ControlType.TextBox)]
        public string KeyWord
        {
            get => keyWord;
            set
            {
                keyWord = value;
                OnPropertyChanged("KeyWord");
            }
        }

        private string secondKeyWord = string.Empty;
        [TaskPane("SecondKeyWordCaption", "SecondKeyWordTooltip", null, 0, false, ControlType.TextBox)]
        public string SecondKeyWord
        {
            get => secondKeyWord;
            set
            {
                secondKeyWord = value;
                OnPropertyChanged("SecondKeyWord");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void Initialize()
        {

        }

        private void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
