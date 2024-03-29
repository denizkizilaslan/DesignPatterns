﻿namespace DesignPattern.AbstractFactory.Abstract
{
    public abstract class Command
    {
        public abstract void Execute();
        public abstract string Query { get; set; } 
        protected string query;
    }
}
