﻿#I "../../bin/"
#r "QuotationCompiler.dll"

open QuotationCompiler

// 1. hello world
let hello = QuotationCompiler.ToFunc <@ printfn "Hello, World!" @>

hello ()

// 2. fibonacci
let fib =
    QuotationCompiler.Eval
        <@
            let rec fib n =
                if n <= 1 then n
                else
                    fib (n-2) + fib(n-1)
            fib
        @>

fib 10