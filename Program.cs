string password="12345678";

if (password.Length<8) {
    Console.WriteLine("Weak password, you neeed to have 8 or more characters in your password");
}

else if (password=="12345678") {
    Console.WriteLine("Your password can't be \"12345678\"");
}

else if (password=="password") {
    Console.WriteLine("Your password can't be \"password\"");
}

else {
    Console.WriteLine("Strong password");
}
