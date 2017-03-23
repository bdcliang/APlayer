using System;
using System.Collections.Generic;
using System.Text;

namespace APlayer
{
    public delegate void Action();
    public delegate void Action<TSource>(TSource arguments);

    //public delegate TSource Func<TSource>();
    public delegate TSource Func<TSource>(params TSource[] arguments);
    public delegate TResult Func<TSource, TResult>(params TSource[] arguments);
}
