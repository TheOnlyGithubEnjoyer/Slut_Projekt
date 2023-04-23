public class Vader
{
    public static string name { get; set; } = "Darth Vader";
    public static string weapon { get; set; } = "Red Lightsaber";
    public static int HP { get; set; } = 200;
    public static int damage = 100;

    public static string GetInformationVader () {
    return " Here Are Your Stats: \n Name: " + Vader.name + "  \n [HP] = " + Vader.HP + " \n [Weapon] = " + Vader.weapon;

    }


}
