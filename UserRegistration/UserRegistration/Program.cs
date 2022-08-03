using UserRegistration;

Console.WriteLine("Welcome to User Registration Problem");

RegexFirstName firstName = new RegexFirstName();

if(firstName.validateString("Madhu"))

{
    Console.WriteLine("The Name is Valid");

}
else
{
    Console.WriteLine("The Name is InValid");
}