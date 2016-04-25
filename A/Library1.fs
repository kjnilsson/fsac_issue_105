module A

let call () =
    let b = B.call "A"
    let c = C.call "A"
    ()
