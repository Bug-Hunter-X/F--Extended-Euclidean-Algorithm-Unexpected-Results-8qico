let rec gcd a b =
    if b = 0 then a
    else gcd b (a % b)

let rec extended_gcd a b =
    if b = 0 then (a, 1, 0)
    else
        let (g, x1, y1) = extended_gcd b (a % b)
        (g, y1, x1 - (a / b) * y1)

let solve () =
    let (g, x, y) = extended_gcd 2 3
    printf "%d %d %d" g x y

solve ()