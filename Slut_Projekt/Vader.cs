public class Vader
{
    public static string name { get; set; } = "Darth Vader";
    public static string weapon = "Red Lightsaber";
    public static int HP = 100;
    public static int damage = 200;

    public static string GetInformationVader () {
    return " Here Are Your Stats: \n Name: " + Vader.name + "  \n [HP] = " + Vader.HP + " \n [Weapon] = " + Vader.weapon;

    }


}
