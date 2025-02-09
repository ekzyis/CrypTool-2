﻿using CrypTool.PluginBase;
using System.ComponentModel;
using System.Windows;
namespace TranspositionAnalyser
{
    internal class TranspositionAnalyserSettings : ISettings
    {
        #region settings
        private int selected_method = 0;

        internal void UpdateTaskPaneVisibility()
        {
            if (TaskPaneAttributeChanged == null)
            {
                return;
            }

            switch (selected_method)
            {
                case 0:
                    TaskPaneAttributeChanged(this, new TaskPaneAttributeChangedEventArgs(new TaskPaneAttribteContainer("MaxLength", Visibility.Visible)));
                    TaskPaneAttributeChanged(this, new TaskPaneAttributeChangedEventArgs(new TaskPaneAttribteContainer("MinLength", Visibility.Collapsed)));
                    TaskPaneAttributeChanged(this, new TaskPaneAttributeChangedEventArgs(new TaskPaneAttribteContainer("CaseSensitive", Visibility.Collapsed)));
                    TaskPaneAttributeChanged(this, new TaskPaneAttributeChangedEventArgs(new TaskPaneAttribteContainer("RowColumnColumn", Visibility.Visible)));
                    TaskPaneAttributeChanged(this, new TaskPaneAttributeChangedEventArgs(new TaskPaneAttribteContainer("RowColumnRow", Visibility.Visible)));
                    TaskPaneAttributeChanged(this, new TaskPaneAttributeChangedEventArgs(new TaskPaneAttribteContainer("ColumnColumnRow", Visibility.Visible)));
                    TaskPaneAttributeChanged(this, new TaskPaneAttributeChangedEventArgs(new TaskPaneAttribteContainer("ColumnColumnColumn", Visibility.Visible)));
                    TaskPaneAttributeChanged(this, new TaskPaneAttributeChangedEventArgs(new TaskPaneAttribteContainer("KeySize", Visibility.Collapsed)));
                    TaskPaneAttributeChanged(this, new TaskPaneAttributeChangedEventArgs(new TaskPaneAttribteContainer("Repeatings", Visibility.Collapsed)));
                    TaskPaneAttributeChanged(this, new TaskPaneAttributeChangedEventArgs(new TaskPaneAttribteContainer("Iterations", Visibility.Collapsed)));
                    TaskPaneAttributeChanged(this, new TaskPaneAttributeChangedEventArgs(new TaskPaneAttribteContainer("CribSearchKeylength", Visibility.Collapsed)));
                    break;
                case 1:
                    TaskPaneAttributeChanged(this, new TaskPaneAttributeChangedEventArgs(new TaskPaneAttribteContainer("MaxLength", Visibility.Collapsed)));
                    TaskPaneAttributeChanged(this, new TaskPaneAttributeChangedEventArgs(new TaskPaneAttribteContainer("MinLength", Visibility.Collapsed)));
                    TaskPaneAttributeChanged(this, new TaskPaneAttributeChangedEventArgs(new TaskPaneAttribteContainer("CaseSensitive", Visibility.Collapsed)));
                    TaskPaneAttributeChanged(this, new TaskPaneAttributeChangedEventArgs(new TaskPaneAttribteContainer("RowColumnColumn", Visibility.Collapsed)));
                    TaskPaneAttributeChanged(this, new TaskPaneAttributeChangedEventArgs(new TaskPaneAttribteContainer("RowColumnRow", Visibility.Collapsed)));
                    TaskPaneAttributeChanged(this, new TaskPaneAttributeChangedEventArgs(new TaskPaneAttribteContainer("ColumnColumnRow", Visibility.Collapsed)));
                    TaskPaneAttributeChanged(this, new TaskPaneAttributeChangedEventArgs(new TaskPaneAttribteContainer("ColumnColumnColumn", Visibility.Collapsed)));
                    TaskPaneAttributeChanged(this, new TaskPaneAttributeChangedEventArgs(new TaskPaneAttribteContainer("KeySize", Visibility.Collapsed)));
                    TaskPaneAttributeChanged(this, new TaskPaneAttributeChangedEventArgs(new TaskPaneAttribteContainer("Repeatings", Visibility.Collapsed)));
                    TaskPaneAttributeChanged(this, new TaskPaneAttributeChangedEventArgs(new TaskPaneAttribteContainer("Iterations", Visibility.Collapsed)));
                    TaskPaneAttributeChanged(this, new TaskPaneAttributeChangedEventArgs(new TaskPaneAttribteContainer("CribSearchKeylength", Visibility.Visible)));
                    break;
                case 2:
                    TaskPaneAttributeChanged(this, new TaskPaneAttributeChangedEventArgs(new TaskPaneAttribteContainer("MaxLength", Visibility.Collapsed)));
                    TaskPaneAttributeChanged(this, new TaskPaneAttributeChangedEventArgs(new TaskPaneAttribteContainer("MinLength", Visibility.Collapsed)));
                    TaskPaneAttributeChanged(this, new TaskPaneAttributeChangedEventArgs(new TaskPaneAttribteContainer("CaseSensitive", Visibility.Collapsed)));
                    TaskPaneAttributeChanged(this, new TaskPaneAttributeChangedEventArgs(new TaskPaneAttribteContainer("RowColumnColumn", Visibility.Collapsed)));
                    TaskPaneAttributeChanged(this, new TaskPaneAttributeChangedEventArgs(new TaskPaneAttribteContainer("RowColumnRow", Visibility.Collapsed)));
                    TaskPaneAttributeChanged(this, new TaskPaneAttributeChangedEventArgs(new TaskPaneAttribteContainer("ColumnColumnRow", Visibility.Collapsed)));
                    TaskPaneAttributeChanged(this, new TaskPaneAttributeChangedEventArgs(new TaskPaneAttribteContainer("ColumnColumnColumn", Visibility.Collapsed)));
                    TaskPaneAttributeChanged(this, new TaskPaneAttributeChangedEventArgs(new TaskPaneAttribteContainer("KeySize", Visibility.Visible)));
                    TaskPaneAttributeChanged(this, new TaskPaneAttributeChangedEventArgs(new TaskPaneAttribteContainer("Repeatings", Visibility.Visible)));
                    TaskPaneAttributeChanged(this, new TaskPaneAttributeChangedEventArgs(new TaskPaneAttribteContainer("Iterations", Visibility.Visible)));
                    TaskPaneAttributeChanged(this, new TaskPaneAttributeChangedEventArgs(new TaskPaneAttribteContainer("CribSearchKeylength", Visibility.Collapsed)));
                    break;
                case 3:
                    TaskPaneAttributeChanged(this, new TaskPaneAttributeChangedEventArgs(new TaskPaneAttribteContainer("MaxLength", Visibility.Collapsed)));
                    TaskPaneAttributeChanged(this, new TaskPaneAttributeChangedEventArgs(new TaskPaneAttribteContainer("MinLength", Visibility.Collapsed)));
                    TaskPaneAttributeChanged(this, new TaskPaneAttributeChangedEventArgs(new TaskPaneAttribteContainer("CaseSensitive", Visibility.Collapsed)));
                    TaskPaneAttributeChanged(this, new TaskPaneAttributeChangedEventArgs(new TaskPaneAttribteContainer("RowColumnColumn", Visibility.Collapsed)));
                    TaskPaneAttributeChanged(this, new TaskPaneAttributeChangedEventArgs(new TaskPaneAttribteContainer("RowColumnRow", Visibility.Collapsed)));
                    TaskPaneAttributeChanged(this, new TaskPaneAttributeChangedEventArgs(new TaskPaneAttribteContainer("ColumnColumnRow", Visibility.Collapsed)));
                    TaskPaneAttributeChanged(this, new TaskPaneAttributeChangedEventArgs(new TaskPaneAttribteContainer("ColumnColumnColumn", Visibility.Collapsed)));
                    TaskPaneAttributeChanged(this, new TaskPaneAttributeChangedEventArgs(new TaskPaneAttribteContainer("KeySize", Visibility.Visible)));
                    TaskPaneAttributeChanged(this, new TaskPaneAttributeChangedEventArgs(new TaskPaneAttribteContainer("Repeatings", Visibility.Visible)));
                    TaskPaneAttributeChanged(this, new TaskPaneAttributeChangedEventArgs(new TaskPaneAttribteContainer("Iterations", Visibility.Visible)));
                    TaskPaneAttributeChanged(this, new TaskPaneAttributeChangedEventArgs(new TaskPaneAttribteContainer("CribSearchKeylength", Visibility.Collapsed)));
                    break;
                case 4:
                    TaskPaneAttributeChanged(this, new TaskPaneAttributeChangedEventArgs(new TaskPaneAttribteContainer("MaxLength", Visibility.Visible)));
                    TaskPaneAttributeChanged(this, new TaskPaneAttributeChangedEventArgs(new TaskPaneAttribteContainer("MinLength", Visibility.Visible)));
                    TaskPaneAttributeChanged(this, new TaskPaneAttributeChangedEventArgs(new TaskPaneAttribteContainer("CaseSensitive", Visibility.Visible)));
                    TaskPaneAttributeChanged(this, new TaskPaneAttributeChangedEventArgs(new TaskPaneAttribteContainer("RowColumnColumn", Visibility.Visible)));
                    TaskPaneAttributeChanged(this, new TaskPaneAttributeChangedEventArgs(new TaskPaneAttribteContainer("RowColumnRow", Visibility.Visible)));
                    TaskPaneAttributeChanged(this, new TaskPaneAttributeChangedEventArgs(new TaskPaneAttribteContainer("ColumnColumnRow", Visibility.Visible)));
                    TaskPaneAttributeChanged(this, new TaskPaneAttributeChangedEventArgs(new TaskPaneAttribteContainer("ColumnColumnColumn", Visibility.Visible)));
                    TaskPaneAttributeChanged(this, new TaskPaneAttributeChangedEventArgs(new TaskPaneAttribteContainer("KeySize", Visibility.Collapsed)));
                    TaskPaneAttributeChanged(this, new TaskPaneAttributeChangedEventArgs(new TaskPaneAttribteContainer("Repeatings", Visibility.Collapsed)));
                    TaskPaneAttributeChanged(this, new TaskPaneAttributeChangedEventArgs(new TaskPaneAttribteContainer("Iterations", Visibility.Collapsed)));
                    TaskPaneAttributeChanged(this, new TaskPaneAttributeChangedEventArgs(new TaskPaneAttribteContainer("CribSearchKeylength", Visibility.Collapsed)));
                    break;
            }
        }

        //[PropertySaveOrder(1)]
        [TaskPane("Analysis_methodCaption", "Analysis_methodTooltip", null, 1, false, ControlType.ComboBox, new string[] { "Analysis_methodList1", "Analysis_methodList2", "Analysis_methodList3", "Analysis_methodList4", "Analysis_methodList5" })]
        public int Analysis_method
        {
            get => selected_method;

            set
            {
                if (value != selected_method)
                {
                    selected_method = value;
                    UpdateTaskPaneVisibility();
                    OnPropertyChanged("Analysis_method");
                }
            }
        }

        private bool caseSensitive = false;
        [PropertySaveOrder(4)]
        [TaskPane("CaseSensitiveCaption", "CaseSensitiveTooltip", null, 2, false, ControlType.CheckBox, "")]
        public bool CaseSensitive
        {
            get => caseSensitive;
            set
            {
                if (value != caseSensitive)
                {
                    caseSensitive = value;
                    OnPropertyChanged("CaseSensitive");
                }
            }
        }

        // FIX: REGEX 
        private int bruteforce_length = 12;
        [PropertySaveOrder(2)]
        [TaskPaneAttribute("MaxLengthCaption", "MaxLengthTooltip", null, 3, false, ControlType.TextBox, ValidationType.RegEx, "[0-9]{1,2}")]
        public int MaxLength
        {
            get => bruteforce_length;
            set
            {
                if (value != bruteforce_length)
                {
                    bruteforce_length = value;
                    OnPropertyChanged("MaxLength");
                }
            }
        }

        private int min_length = 1;
        [PropertySaveOrder(2)]
        [TaskPaneAttribute("MinLengthCaption", "MinLengthTooltip", null, 2, false, ControlType.TextBox, ValidationType.RegEx, "[0-9]{1,2}")]
        public int MinLength
        {
            get => min_length;
            set
            {
                if (value != min_length)
                {
                    min_length = value;
                    OnPropertyChanged("MinLength");
                }
            }
        }

        private int keysize = 8;
        [PropertySaveOrder(3)]
        [TaskPaneAttribute("KeySizeCaption", "KeySizeTooltip", null, 4, false, ControlType.TextBox, ValidationType.RegEx, "[0-9]{1,2}")]
        public int KeySize
        {
            get => keysize;
            set
            {
                if (value != keysize)
                {
                    keysize = value;
                    OnPropertyChanged("KeySize");
                }
            }
        }

        private bool row_colum_column = true;
        [PropertySaveOrder(4)]
        [TaskPane("RowColumnColumnCaption", "RowColumnColumnTooltip", null, 4, false, ControlType.CheckBox, "")]
        public bool RowColumnColumn
        {
            get => row_colum_column;
            set
            {
                if (value != row_colum_column)
                {
                    row_colum_column = value;
                    OnPropertyChanged("RowColumnColumn");
                }
            }
        }

        private bool row_colum_row = true;
        [PropertySaveOrder(5)]
        [TaskPane("RowColumnRowCaption", "RowColumnRowTooltip", null, 4, false, ControlType.CheckBox, "")]
        public bool RowColumnRow
        {
            get => row_colum_row;
            set
            {
                if (value != row_colum_row)
                {
                    row_colum_row = value;
                    OnPropertyChanged("RowColumnRow");
                }
            }
        }


        private bool column_colum_row = true;
        [PropertySaveOrder(6)]
        [TaskPane("ColumnColumnRowCaption", "ColumnColumnRowTooltip", null, 4, false, ControlType.CheckBox, "")]
        public bool ColumnColumnRow
        {
            get => column_colum_row;
            set
            {
                if (value != column_colum_row)
                {
                    column_colum_row = value;
                    OnPropertyChanged("ColumnColumnRow");
                }
            }
        }

        private bool column_colum_column = true;
        [PropertySaveOrder(7)]
        [TaskPane("ColumnColumnColumnCaption", "ColumnColumnColumnTooltip", null, 4, false, ControlType.CheckBox, "")]
        public bool ColumnColumnColumn
        {
            get => column_colum_column;
            set
            {
                if (value != column_colum_column)
                {
                    column_colum_column = value;
                    OnPropertyChanged("ColumnColumnColumn");
                }
            }
        }

        private int repeatings = 10;
        [PropertySaveOrder(8)]
        [TaskPaneAttribute("RepeatingsCaption", "RepeatingsTooltip", null, 2, true, ControlType.TextBox, ValidationType.RegEx, "[0-9]{1,2}")]
        public int Repeatings
        {
            get => repeatings;
            set
            {
                if (value != repeatings)
                {
                    repeatings = value;
                    OnPropertyChanged("Repeatings");
                }
            }
        }

        private int iterations = 5000;
        [PropertySaveOrder(9)]
        [TaskPaneAttribute("IterationsCaption", "IterationsTooltip", null, 3, true, ControlType.TextBox, ValidationType.RegEx, "[0-9]{1,2}")]
        public int Iterations
        {
            get => iterations;
            set
            {
                if (value != iterations)
                {
                    iterations = value;
                    OnPropertyChanged("Iterations");
                }
            }
        }

        private int cribSearchKeylength = 12;
        [PropertySaveOrder(10)]
        [TaskPaneAttribute("CribSearchKeylengthCaption", "CribSearchKeylengthTooltip", null, 3, true, ControlType.TextBox, ValidationType.RegEx, "[0-9]{1,2}")]
        public int CribSearchKeylength
        {
            get => cribSearchKeylength;
            set
            {
                if (value != cribSearchKeylength)
                {
                    cribSearchKeylength = value;
                    OnPropertyChanged("CribSearchKeylength");
                }
            }
        }

        #endregion

        #region Events

        public event TaskPaneAttributeChangedHandler TaskPaneAttributeChanged;

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        public void Initialize()
        {
            UpdateTaskPaneVisibility();
        }

        private void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
        #endregion
    }
}
