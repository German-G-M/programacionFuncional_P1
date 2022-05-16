// Learn more about F# at http://fsharp.org

open System
let suma a b=a+b
let resta a b =a-b
let multiplicacion a b =a*b
let division a b = a/b

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    printfn "=========OPERACIONES ARITMÉTICAS CON F#======="
    printf ""
    printfn "Introduzca 2 números"
    let num1=Convert.ToDouble(Console.ReadLine())
    let num2=Convert.ToDouble(Console.ReadLine())
    Console.WriteLine("La suma de ["+num1.ToString()+"] y ["+num2.ToString()+"] es : "+(suma num1 num2).ToString())
    Console.WriteLine("La resta de ["+num1.ToString()+"] y ["+num2.ToString()+"] es : "+(resta num1 num2).ToString())
    Console.WriteLine("La multiplicación de ["+num1.ToString()+"] y ["+num2.ToString()+"] es : "+(multiplicacion num1 num2).ToString())
    Console.WriteLine("La división de ["+num1.ToString()+"] y ["+num2.ToString()+"] es : "+(division num1 num2).ToString())
    let tecla=Console.ReadKey()
    0 // return an integer exit code
