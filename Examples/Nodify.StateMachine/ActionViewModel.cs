﻿namespace Nodify.StateMachine
{
    public class ActionViewModel : ObservableObject
    {
        private string? _name;
        public string? Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }
    }
}