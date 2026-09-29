using UnityEngine;

// ==========================================================================
// THE DUNGEON - Homework (Intro to C#  +  Variables & Operators)
// --------------------------------------------------------------------------
// One growing program - keep building this SAME file.
//   PART A: do after the INTRO lecture (uses only Debug.Log).
//   PART B: finish after the VARIABLES lecture (variables & operators).
// Attach to an empty GameObject and press Play to test as you go.
// ==========================================================================
public class DungeonGame : MonoBehaviour
{
    void Start()
    {
        // (PART B) TODO B1: declare your stats here, at the very top of Start,
        //          once you have had the Variables lecture. You will need:
        //            playerName (string), health (int), attack (int),
        //            agility (int), gold (int), hasKey (bool),
        //            goblinHealth (int), goblinAttack (int).
        string playerName = "Flip";
        int playerArmor = 2;
        int playerPotions = 0;
        int playerHealth = 15;
        int playerMaxHealth = 15;
        int playerAttack = 2;
        int playerAgility = 5;
        int playerGold = 15;
        bool hasKey = false;
        int goblinHealth = 3;
        int goblinAttack = 2;
        int goblinArmor = 2;
        int ogreHealth = 20;
        int ogreAttack = 4;
        int ogreArmor = 2;
        int spiderHealth = 15;
        int spiderAttack = 2;
        int spiderArmor = 3;
        int spiderVenomDamage = 2;
        bool spiderBite = false;
        int spiderBiteDuration = 3;
        int playerCritDamage = 2;
        int heavyAttackCounter = 0;
        int heavyAttackCounterMax = 1;
        bool spiderVenomTaken = false;
        int roomNumber = 0;
        int campfireCounter = 10;



        // ===== ALREADY BUILT IN CLASS (Intro lecture): the opening + two rooms =====
        Debug.Log("=== THE DUNGEON ===");
        Debug.Log("Welcome, " + playerName + ". Your escape begins."); // replace Hero with the name of your player.

        Debug.Log("");
        Debug.Log("The Entrance Hall");
        Debug.Log("A torch flickers on the wall. A stone doorway leads north.");
        roomNumber += 1;
        if (roomNumber % 3 == 0)
        {
            Debug.Log("Room has a red glow");
        }
        Debug.Log("You move into the next room.");

        Debug.Log("");
        Debug.Log("The Guard Room");
        Debug.Log("A rusty sword rests on a table. A goblin snores in the corner.");
        roomNumber += 1;
        if (roomNumber % 3 == 0)
        {
            Debug.Log("Room has a red glow");
        }
        Debug.Log("You pick up the sword which gives you an extra 2 attack, the goblin wakes up because of the noise");
        playerAttack += 2;
        Debug.Log("You now have " + playerAttack + " attack");
        Debug.Log("The goblin attacks you, it has an attack power of " + goblinAttack);
        //Goblin attacks

        do
        {
            int playerLuck = Random.Range(1, 6);
            int enemyLuck = Random.Range(1, 4);

            if (playerLuck < goblinArmor)
            {
                Debug.Log("Goblin's armor deflected your attack");

                if (enemyLuck < playerArmor)
                {
                    Debug.Log("You deflected the goblin's attack");
                }
                else if (enemyLuck > playerArmor)
                {
                    playerHealth -= goblinAttack;
                    Debug.Log("You took " + goblinAttack + " damage from the goblin");
                    if (playerHealth <= 0)
                    {
                        Debug.Log(playerName + " Collapsed");
                        break;
                    }
                    else if (playerHealth <= 2)
                    {
                        Debug.Log(playerName + " is badly injured");
                    }
                    else
                    {
                        Debug.Log(playerName + " is fine");
                    }
                }






            }

            else if (playerLuck > goblinArmor && playerLuck >= 4)
            {
                goblinHealth -= playerAttack;
                goblinHealth -= playerCritDamage;
                Debug.Log("You dealt " + playerAttack + " plus " + playerCritDamage + " damage to the goblin with a critical hit");

                if (enemyLuck < playerArmor && goblinHealth > 0)
                {
                    Debug.Log("You deflected the goblin's attack");
                }
                else if (enemyLuck > playerArmor && goblinHealth > 0)
                {
                    playerHealth -= goblinAttack;
                    Debug.Log("You took " + goblinAttack + " damage from the goblin");
                    if (playerHealth <= 0)
                    {
                        Debug.Log(playerName + " Collapsed");
                        break;
                    }
                    else if (playerHealth <= 2)
                    {
                        Debug.Log(playerName + " is badly injured");
                    }
                    else
                    {
                        Debug.Log(playerName + " is fine");
                    }

                }

            }
            else if (playerLuck > goblinArmor)
            {
                goblinHealth -= playerAttack;
                Debug.Log("You dealt " + playerAttack + " damage to the goblin");

                if (enemyLuck < playerArmor && goblinHealth > 0)
                {
                    Debug.Log("You deflected the goblin's attack");
                }
                else if (enemyLuck > playerArmor && goblinHealth > 0)
                {
                    playerHealth -= goblinAttack;
                    Debug.Log("You took " + goblinAttack + " damage from the goblin");
                    if (playerHealth <= 0)
                    {
                        Debug.Log(playerName + " Collapsed");
                        break;
                    }
                    else if (playerHealth <= 2)
                    {
                        Debug.Log(playerName + " is badly injured");
                    }
                    else
                    {
                        Debug.Log(playerName + " is fine");
                    }

                }

            }


        } while (playerHealth > 0 && goblinHealth > 0);



        if (goblinHealth <= 0)
        {
            Debug.Log("You defeated the goblin");
        }
        else if (playerHealth <= 0)
        {
            Debug.Log("You were defeated by the goblin");
        }










        Debug.Log("You move into the next room.");

        // ======================================================================
        // PART A  -  after the INTRO lecture (Debug.Log only)
        // ======================================================================

        // TODO A1: FIX THE BROKEN ROOM below. It has bugs that stops the program
        //          from running. Un-comment the lines, find the bug(s), fix it,
        //          and add a // comment saying what was wrong.
        Debug.Log("The Flooded Passage");
        Debug.Log("Ankle-deep water fills the hall. A broken door is at the end of the hallway.");
        roomNumber += 1;
        if (roomNumber % 3 == 0)
        {
            Debug.Log("Room has a red glow");
        }
        Debug.Log("Your boots are filled with water and you lose 1 agility");
        playerAgility -= 1;
        Debug.Log("You now have " + playerAgility + " agility");
        Debug.Log("There is a ogre blocking your path");
        Debug.Log("You attack the ogre");
        do
        {




            int playerLuck = Random.Range(1, 6);
            int enemyLuck = Random.Range(1, 6);

            if (playerLuck < ogreArmor)
            {
                Debug.Log("Ogre's armor deflected your attack");

                if (heavyAttackCounter == 0)
                {
                    if (enemyLuck < playerArmor)
                    {
                        Debug.Log("You deflected the ogre's attack");
                        heavyAttackCounter = heavyAttackCounterMax;
                    }
                    else if (enemyLuck > playerArmor)
                    {
                        playerHealth -= ogreAttack;
                        heavyAttackCounter = heavyAttackCounterMax;
                        Debug.Log("You took " + ogreAttack + " damage from the ogre");
                        if (playerHealth <= 0)
                        {
                            Debug.Log(playerName + " Collapsed");
                            break;
                        }
                        else if (playerHealth <= 2)
                        {
                            Debug.Log(playerName + " is badly injured");
                        }
                        else
                        {
                            Debug.Log(playerName + " is fine");
                        }
                    }
                }
                else
                {
                    heavyAttackCounter -= 1;
                }






            }

            else if (playerLuck > ogreArmor && playerLuck >= 4)
            {
                ogreHealth -= playerAttack;
                ogreHealth -= playerCritDamage;
                Debug.Log("You dealt " + playerAttack + " plus " + playerCritDamage + " damage to the ogre with a critical hit");

                if (heavyAttackCounter == 0)
                {
                    if (enemyLuck < playerArmor && ogreHealth > 0)
                    {
                        Debug.Log("You deflected the ogre's attack");
                        heavyAttackCounter = heavyAttackCounterMax;
                    }
                    else if (enemyLuck > playerArmor && ogreHealth > 0)
                    {
                        playerHealth -= ogreAttack;
                        heavyAttackCounter = heavyAttackCounterMax;
                        Debug.Log("You took " + ogreAttack + " damage from the ogre");
                        if (playerHealth <= 0)
                        {
                            Debug.Log(playerName + " Collapsed");
                            break;
                        }
                        else if (playerHealth <= 2)
                        {
                            Debug.Log(playerName + " is badly injured");
                        }
                        else
                        {
                            Debug.Log(playerName + " is fine");
                        }
                    }
                }
                else
                {
                    heavyAttackCounter -= 1;
                }
            }
            else if (playerLuck > ogreArmor)
            {
                ogreHealth -= playerAttack;
                Debug.Log("You dealt " + playerAttack + " damage to the ogre");

                if (heavyAttackCounter == 0)
                {
                    if (enemyLuck < playerArmor && ogreHealth > 0)
                    {
                        Debug.Log("You deflected the ogre's attack");
                        heavyAttackCounter = heavyAttackCounterMax;
                    }
                    else if (enemyLuck > playerArmor && ogreHealth > 0)
                    {
                        playerHealth -= ogreAttack;
                        heavyAttackCounter = heavyAttackCounterMax;
                        Debug.Log("You took " + ogreAttack + " damage from the ogre");
                        if (playerHealth <= 0)
                        {
                            Debug.Log(playerName + " Collapsed");
                            break;
                        }
                        else if (playerHealth <= 2)
                        {
                            Debug.Log(playerName + " is badly injured");
                        }
                        else
                        {
                            Debug.Log(playerName + " is fine");
                        }
                    }
                }
                else
                {
                    heavyAttackCounter -= 1;
                }
            }


        } while (playerHealth > 0 && ogreHealth > 0);



        if (ogreHealth <= 0)
        {
            Debug.Log("You defeated the ogre");
        }
        else if (playerHealth <= 0)
        {
            Debug.Log("You were defeated by the ogre");
        }
        Debug.Log("You move into the next room.");

        // TODO A2: write at least one of your OWN room - a Room Name line,
        //          a description line, and a line describing how you exit. 
        Debug.Log("The Dusty Library");
        Debug.Log("The walls are covered in dusty books from floor to ceiling, there is a large door at the end of the room, and there is a merchant selling potions");
        roomNumber += 1;
        if (roomNumber % 3 == 0)
        {
            Debug.Log("Room has a red glow");
        }
        Debug.Log("You buy a potion from the merchant for 5 gold");

        playerGold -= 5;
        playerPotions += 1;
        Debug.Log("You now have " + playerGold + " gold");
        Debug.Log("You now have " + playerPotions + " potions");

        int playerKeyChance = Random.Range(1, 10);
        if (playerKeyChance <= 3)
        {
            Debug.Log("You walk away and see nothing on the ground");
        }
        else if (playerKeyChance >= 4)
        {
            hasKey = true;
            Debug.Log("You find a key on the floor");

        }

        Debug.Log("You move into the next room.");
        // TODO A3: write the EXIT room - a final "room" and description that leads the
        //          player out of the dungeon.





        Debug.Log("you reach a vault door and a long hallway around the vault");

        if (hasKey && playerHealth > 0)
        {
            Debug.Log("The Treasure Room");
            roomNumber += 1;
            if (roomNumber % 3 == 0)
            {
                Debug.Log("Room has a red glow");
            }
            playerGold += 5000;
            Debug.Log("It seems this room has been raided. You find " + 5000 + " gold.");
            Debug.Log("You now have " + playerGold + " gold");
            Debug.Log("You move into the next room.");
        }
        else if (playerHealth <= 0)
        {
            Debug.Log("You are dead and can't continue");

        }
        else
        {
            Debug.Log("You do not have a key and must go around");
            roomNumber += 1;
            if (roomNumber % 3 == 0)
            {
                Debug.Log("The path around has a red glow");
            }
        }




        Debug.Log("Long stair case");
        Debug.Log("A long staircase that leads to a large wooden door");
        roomNumber += 1;
        if (roomNumber % 3 == 0)
        {
            Debug.Log("Room has a red glow");
        }
        Debug.Log("A spider drops down from the ceiling");
        Debug.Log("You attack the spider");

        do
        {



            if (spiderBite == true && spiderVenomTaken == false)
            {
                if (spiderBiteDuration > 0)
                {
                    playerHealth -= spiderVenomDamage;
                    spiderBiteDuration -= 1;
                    spiderVenomTaken = true;
                    Debug.Log("You took " + spiderVenomDamage + " venom damage from the spider");
                    if (playerHealth <= 0)
                    {
                        Debug.Log(playerName + " Collapsed");
                        break;
                    }
                    else if (playerHealth <= 2)
                    {
                        Debug.Log(playerName + " is badly injured");
                    }
                    else
                    {
                        Debug.Log(playerName + " is fine");
                    }
                }
                else if (spiderBiteDuration == 0)
                {
                    spiderBite = false;
                    spiderBiteDuration = 3;
                }


            }



            int playerLuck = Random.Range(1, 6);
            int enemyLuck = Random.Range(1, 6);

            if (playerLuck < spiderArmor)
            {
                Debug.Log("Spider's armor deflected your attack");

                if (heavyAttackCounter == 0)
                {
                    if (enemyLuck < playerArmor)
                    {
                        Debug.Log("You deflected the spider's attack");
                        heavyAttackCounter = heavyAttackCounterMax;
                        spiderVenomTaken = false;
                    }
                    else if (enemyLuck > playerArmor)
                    {
                        playerHealth -= spiderAttack;
                        spiderBite = true;
                        heavyAttackCounter = heavyAttackCounterMax;
                        spiderVenomTaken = false;
                        Debug.Log("You took " + spiderAttack + " damage from the spider");
                        if (playerHealth <= 0)
                        {
                            Debug.Log(playerName + " Collapsed");
                            break;
                        }
                        else if (playerHealth <= 2)
                        {
                            Debug.Log(playerName + " is badly injured");
                        }
                        else
                        {
                            Debug.Log(playerName + " is fine");
                        }
                    }
                }
                else
                {
                    heavyAttackCounter -= 1;
                    spiderVenomTaken = false;
                }






            }

            else if (playerLuck > spiderArmor && playerLuck >= 4)
            {
                spiderHealth -= playerAttack;
                spiderHealth -= playerCritDamage;
                Debug.Log("You dealt " + playerAttack + " plus " + playerCritDamage + " damage to the spider with a critical hit");

                if (heavyAttackCounter == 0)
                {
                    if (enemyLuck < playerArmor && spiderHealth > 0)
                    {
                        Debug.Log("You deflected the spider's attack");
                        heavyAttackCounter = heavyAttackCounterMax;
                        spiderVenomTaken = false;
                    }
                    else if (enemyLuck > playerArmor && spiderHealth > 0)
                    {
                        playerHealth -= spiderAttack;
                        spiderBite = true;
                        heavyAttackCounter = heavyAttackCounterMax;
                        spiderVenomTaken = false;
                        Debug.Log("You took " + spiderAttack + " damage from the spider");
                        if (playerHealth <= 0)
                        {
                            Debug.Log(playerName + " Collapsed");
                            break;
                        }
                        else if (playerHealth <= 2)
                        {
                            Debug.Log(playerName + " is badly injured");
                        }
                        else
                        {
                            Debug.Log(playerName + " is fine");
                        }
                    }
                }
                else
                {
                    heavyAttackCounter -= 1;
                    spiderVenomTaken = false;
                }
            }
            else if (playerLuck > spiderArmor)
            {
                spiderHealth -= playerAttack;
                Debug.Log("You dealt " + playerAttack + " damage to the spider");

                if (heavyAttackCounter == 0)
                {
                    if (enemyLuck < playerArmor && spiderHealth > 0)
                    {
                        Debug.Log("You deflected the spider's attack");
                        heavyAttackCounter = heavyAttackCounterMax;
                        spiderVenomTaken = false;
                    }
                    else if (enemyLuck > playerArmor && spiderHealth > 0)
                    {
                        playerHealth -= spiderAttack;
                        spiderBite = true;
                        heavyAttackCounter = heavyAttackCounterMax;
                        spiderVenomTaken = false;
                        Debug.Log("You took " + spiderAttack + " damage from the spider");
                        if (playerHealth <= 0)
                        {
                            Debug.Log(playerName + " Collapsed");
                            break;
                        }
                        else if (playerHealth <= 2)
                        {
                            Debug.Log(playerName + " is badly injured");
                        }
                        else
                        {
                            Debug.Log(playerName + " is fine");
                        }
                    }
                }
                else
                {
                    heavyAttackCounter -= 1;
                    spiderVenomTaken = false;
                }
            }


        } while (playerHealth > 0 && spiderHealth > 0);



        if (spiderHealth <= 0)
        {
            Debug.Log("You defeated the spider");
        }
        else if (playerHealth <= 0)
        {
            Debug.Log("You were defeated by the spider");
        }

        Debug.Log("You move to the door and exit the dungeon");

        Debug.Log("You find a campfire");
        while (playerHealth != playerMaxHealth && campfireCounter > 0)
        {

            Debug.Log("You sit at the campfire to regain health and regain 1 health");
            playerHealth += 1;
            campfireCounter -= 1;
        }
        Debug.Log("You now have " + playerHealth + " health");
        // ======================================================================
        // PART B  -  after the VARIABLES lecture (variables & operators)
        // ======================================================================

        // TODO B2: FIX THE BROKEN ROOM below. It has bugs that stops the program
        //          from running. Un-comment the lines, find the bug(s), fix it,
        //          and add a // comment saying what was wrong.


        // TODO B3: Go back through your rooms above and add an event/item to each
        //          one that changes a stat/variable, printing the new value right
        //          after the event. Like with the gold in the treasure room, keep
        //          each event inside the room where it happens. Possible events:
        //            pick up a sword to increase attack      
        //            step on a trap        
        //            grab the rusty key    
        //            (your own event)

        // TODO B4: In the appropriate room, add a goblin. The goblin attacks the
        //          player and the player attacks the goblin. Use the variables
        //          you've created in PART A to simulate this with code. After the
        //          simulation is done, Print both healths, then print whether or 
        //          not the goblin is defeated. 

        // TODO B5: Add a new room somewhere before the exit that has a merchant. 
        //          The merchant sells potions for 5 gold each. Print how many
        //          potions you can afford and how much gold you will have left over. 

        // TODO B6: Add a defense stat (declare it up top with the others). Use it
        //          in your combat so the goblin's hit damage is reduced by your
        //          defense and your hit damage is reduced by the goblin's defense
        //          Then, add an item that raises defense in a room. 
    }
}
// ================= PART A - CONDITIONALS (do after L7) =================

// A1: After the goblin fight, report whether the goblin was defeated or

//     the hero was the one who fell.

// A2: At a vault door, the hero may pass only if they are carrying the

//     key and are still alive. If they cannot pass, report which of the

//     two requirements they are missing.

// A3: The passage forks in two. Send the hero down one of the routes and

//     describe each one - the two routes may even rejoin at the same

//     place further on.

// A4: As the hero explores, every third room they enter has a red glow.

//     Given the number of the room the hero is standing in, report

//     whether this room has the red glow.

// A5: Whenever the hero takes damage, report their condition: collapsed

//     if no health remains, badly wounded if their health has dropped

//     dangerously low, or otherwise hurt but steady. This is a snippet

//     you will reuse a lot - go back through everything you have already

//     written (INCLUDING your previous assignment) and drop it in right

//     after every place the hero loses health (the spike trap, and

//     anywhere else). You will add it again in Part B after each hit the

//     hero takes in a fight.



// ================= PART B - LOOPS (do after L8) =================

// Place the following combat encounters in different rooms of your choice.

// B1: A goblin blocks the way - fight it round by round until one of you

//     runs out of health. Give the hero and the goblin each an armor

//     class. On every swing, roll a die (Random.Range works well) and

//     compare it to the target's armor class: the blow only lands if the

//     roll meets or beats that armor class. On top of that, any of the

//     hero's landed hits can be a critical hit that deals extra damage.

//     Report each roll and its result, and after any round in which the

//     hero takes damage, run your A5 condition check.

// B2: Beyond the goblin waits an ogre - slow, but brutal. Fight it the

//     same way (armor classes, dice rolls to hit, and the hero's chance

//     to crit), except the ogre is so sluggish it only swings every

//     other round. Fight until one of them falls, and keep running your

//     A5 check whenever the hero takes damage.

// B3: Then a giant spider drops from the ceiling. Fight it just like the

//     ogre - dice-and-armor-class swings, the hero's crits, and it too

//     only strikes every other round - but its bite is venomous: any

//     time it lands a hit, the hero is poisoned and loses 2 health at

//     the start of each of the next three rounds, on top of the bite

//     itself. Fight until one of them falls, running your A5 check after

//     any damage (including the poison ticks).

// B4: With the fights behind them, the hero rests at a campfire,

//     recovering a little health each turn until fully healed or the

//     fire dies after a set number of turns. Report their health as it

//     climbs, and never let it rise above the maximum.