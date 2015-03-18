using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;

namespace eu.satam.som.ui.Common
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            var propertyChanged = this.PropertyChanged;

            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        protected bool SetProperty<T>(ref T backingField, T value, Expression<Func<T>> propertyExpression)
        {
            var changed = !EqualityComparer<T>.Default.Equals(backingField, value);
            if (!changed) { return false; }

            backingField = value;
            this.RaisePropertyChanged(ExtractPropertyName(propertyExpression));

            return true;
        }

        private static string ExtractPropertyName<T>(Expression<Func<T>> propertyExpression)
        {
            var memberExp = propertyExpression.Body as MemberExpression;

            if (memberExp == null)
            {
                throw new ArgumentException(@"Expression must be a MemberExpression.", "propertyExpression");
            }

            return memberExp.Member.Name;
        }
    }
}