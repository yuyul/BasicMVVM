﻿using BasicMVVM.Commands;
using BasicMVVM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace BasicMVVM.ViewModels
{
    public class ViewModel: INotifyPropertyChanged
    {
        private ICommand _SetTitleCommand;
        private ICommand _AddItemCommand;
        private ICommand showYesNoQuestionCommand;
        private String _title;
        private ItemsList _items = new ItemsList();
        private Model _selectedItem;
        private String _answer;

        public Model SelectedItem
        {
            get
            {
                return _selectedItem;
            }
            set
            {
                _selectedItem = value;
                NotifyPropertyChanged("SelectedItem");
            }
        }

        public ItemsList Items
        {
            get
            {
                return _items;
            }
        }

        public string Title {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
                NotifyPropertyChanged("Title");
            }
        }
        

        public ViewModel()
        {
            Title = "My title";
        }

        public ICommand SetTextCommand
        {
            get
            {
                this._SetTitleCommand = new RelayCommand()
                {
                    CanExecuteDelegate = c => CanUpdateTitle(),
                    ExecuteDelegate = c => SetTitle()
                };
                return this._SetTitleCommand;

            }
        }

        private bool CanUpdateTitle()
        {
            return Title.Length < 50;
        }

        private void SetTitle()
        {
            Title += " grows!";
        }

        public ICommand AddItemCommand
        {
            get
            {
                this._AddItemCommand = new RelayCommand()
                {
                    CanExecuteDelegate = p => true,
                    ExecuteDelegate = p => AddItem()
                };
                return this._AddItemCommand;
            }

        }

        private void AddItem()
        {
            Model newItem = new Model();
            newItem.Code = _items.Count == 0 ? 1 : _items[_items.Count - 1].Code + 1;
            newItem.Name = "Item #" + newItem.Code;

            _items.Add(newItem);
            NotifyPropertyChanged("Items");
            
        }




        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }


        public string Answer
        {
            get
            {
                return _answer;
            }
 
            set
            {
                _answer = value;
                NotifyPropertyChanged("Answer");
            }
        }

        public ICommand ShowYesNoQuestionCommand
        {
          get
          {
              this.showYesNoQuestionCommand = new RelayCommand()
              {
                  CanExecuteDelegate = p => true,
                  ExecuteDelegate = p => { ShowYesNoQuestion("Are you sure?"); }
              };
              return this.showYesNoQuestionCommand;
          }
        }
 
        private bool ShowYesNoQuestion(string message)
        {
          MessageBoxResult result = MessageBox.Show(
              message,
              "Question",
              MessageBoxButton.YesNo,
              MessageBoxImage.Question);
 
          switch (result)
          {
              case MessageBoxResult.Yes:
                  this.Answer = "Your answer is Yes";
                  return true;
 
              default:
                  this.Answer = "Your answer is No";
                  return false;
          }
        }



    }
}
