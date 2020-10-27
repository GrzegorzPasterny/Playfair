// Learn more about F# at http://fsharp.org

open System


let Playfair = 
    
    let text = 
        Console.WriteLine("Type text to process:")
        Console.ReadLine().Replace(" ","").ToLower()

    let dir = 
        Console.WriteLine("To encrypt type '1', to decyrpt type '0', otherwise quit:")
        Console.ReadLine()

    let keyWord = 
        Console.WriteLine("Type key word:")
        Console.ReadLine().Replace(" ","").ToLower()


    let run = 
        
        let textToInt text = 
            text.ToCharArray()
            |> List.ofArray
            |> List.map(fun i -> int i)
            |> List.map(fun i -> i - 97)
    
        let toStringAgain text = 
            text 
            |> List.map(fun i -> i + 97)
            |> List.map (fun i -> char i)
            |> String.Concat

        //let encrypt =
            
        //    let calculate singleLetter =
        //        (a * singleLetter + b) % 26
            
        //    text
        //    |> List.map(fun i -> calculate i)
            
        //let decrypt = 
            
        //    let calculate singleLetter =
        //        (aMinus1 * (singleLetter - b)) % 26
            
        //    text
        //    |> List.map(fun i -> calculate i)

        let simpleArray =
            [0 .. 1 .. 24]

        let keyWordTable =
            List.map2 (fun i j -> i + j) simpleArray (textToInt text)

        let keyWordTableToString = 
            0


        text
        dir
        keyWord
        //Console.Write(keyWordToString)

        match dir with
        | "1" -> 
            encrypt textToInt
            |> toStringAgain

        | "0" -> 
            decrypt textToInt
            |> toStringAgain

        | _ -> 
            "invalid choose between encrypion and decryption"

    run


[<EntryPoint>]
let main argv =
    Console.WriteLine(Playfair)
    0
