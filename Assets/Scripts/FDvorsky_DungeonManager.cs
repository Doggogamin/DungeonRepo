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
        string[] roomNames = 
            {
            "The Entrance Hall",
            "The Guard Room",
            "The Flooded Passage",
            "The Dusty Library",
            "The Treasure Room",
            "Long stair case"
        };
        string[] roomDescriptions =
            {
            "A torch flickers on the wall. A stone doorway leads north.",
            "A rusty sword rests on a table. A goblin snores in the corner.",
            "Ankle-deep water fills the hall. A broken door is at the end of the hallway.",
            "The walls are covered in dusty books from floor to ceiling, there is a large door at the end of the room, and there is a merchant selling potions",
            "It seems this room has been raided.",
            "A long staircase that leads to a large wooden door" 
        };
        foreach (string roomName in roomNames)
        {
            Debug.Log(roomName);
        }
        
        string playerName = "Flip";
        //
        int playerArmor = 2;
        //
        int playerPotions = 0;
        //
        int playerHealth = 15;
        //
        int playerMaxHealth = 15;
        //
        int playerAttack = 2;
        //
        int playerAgility = 5;
        //
        int playerGold = 15;
        //
        
        //
        int spiderVenomDamage = 2;
        bool spiderBite = false;
        int spiderBiteDuration = 3;
        bool spiderVenomTaken = false;
        //
        int playerCritDamage = 2;
        int heavyAttackCounter = 0;
        int heavyAttackCounterMax = 1;
        
        //
        bool playerAlive = true;
        //
        string[] enemyNames =
            {
            "Goblin",
            "Ogre",
            "Spider"
        };
        int swordDamageBoost = 2;
        int[] enemyHealth = { 3, 20, 15, };
        int[] enemyAttack = { 2, 4, 2 };
        int[] enemyArmor = { 2, 2, 3 };
        int[] roomEnemy = { -1, 0, 1, -1, -1, 2 };
        int[] roomGold = { 0, 0, 0, 0, 5000, 0 };
        string[] items = { "empty weapon slot", "empty heal slot", "empty shield slot", "empty key slot" };
        bool[] visitedRooms = { false, false, false, false, false, false };
        string[] possibleRewards = { "Sword", "Key", "Potion" };
        int roomNumber = 0;
        //
        Debug.Log("=== THE DUNGEON ===");
        Debug.Log("Welcome, " + playerName + ". Your escape begins.");
        Debug.Log("Your possible rewards include");
        foreach (string possibleReward in possibleRewards)
        {
            Debug.Log(possibleReward);
        }
        //room 1 index 0
        Debug.Log("");
        Debug.Log(roomNames[roomNumber]);
        Debug.Log(roomDescriptions[roomNumber]);
        visitedRooms[roomNumber] = true;
        if (roomNumber % 3 == 0)
        {
            Debug.Log("Room has a red glow");
        }
        Debug.Log("You move into the next room.");
        //room 2 index 1
        roomNumber += 1;
        Debug.Log("");
        Debug.Log(roomNames[roomNumber]);
        Debug.Log(roomDescriptions[roomNumber]);
        visitedRooms[roomNumber] = true;
        if (roomNumber % 3 == 0)
        {
            Debug.Log("Room has a red glow");
        }
        Debug.Log("You pick up the sword which gives you an extra 2 attack, the goblin wakes up because of the noise");
        items[0] = "Sword";
        Debug.Log("The goblin attacks you, it has an attack power of " + enemyAttack[roomEnemy[roomNumber]]);
        //Goblin Fight

        do
        {
            
            int playerRandomChance = Random.Range(1, 6);
            int enemyRandomChance = Random.Range(1, 4);
            

            if (playerRandomChance < enemyArmor[roomEnemy[roomNumber]])
            {
                Debug.Log(enemyNames[roomEnemy[roomNumber]] + " armor deflected your attack");

                if (enemyRandomChance < playerArmor)
                {
                    Debug.Log("You deflected the " + enemyNames[roomEnemy[roomNumber]] + " attack");
                }
                else if (enemyRandomChance > playerArmor)
                {
                    playerHealth -= enemyAttack[roomEnemy[roomNumber]];
                    Debug.Log("You took " + enemyAttack[roomEnemy[roomNumber]] + " damage from the " + enemyNames[roomEnemy[roomNumber]]);
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
            
            else if (playerRandomChance > enemyArmor[roomEnemy[roomNumber]] && playerRandomChance >= 4)
            {
                if (items[0] == "Sword")
                {
                    enemyHealth[roomEnemy[roomNumber]] -= swordDamageBoost + playerAttack + playerCritDamage;
                    Debug.Log("You dealt " + playerAttack + " plus " + playerCritDamage + "plus" + swordDamageBoost + " damage to the " + enemyNames[roomEnemy[roomNumber]] + " with a critical hit");
                    
                        if (enemyRandomChance < playerArmor && enemyHealth[roomEnemy[roomNumber]] > 0)
                        {
                            Debug.Log("You deflected the " + enemyNames[roomEnemy[roomNumber]] + " attack");
                            
                            
                        }
                        else if (enemyRandomChance > playerArmor && enemyHealth[roomEnemy[roomNumber]] > 0)
                        {
                            playerHealth -= enemyAttack[roomEnemy[roomNumber]];
                            
                            Debug.Log("You took " + enemyAttack[roomEnemy[roomNumber]] + " damage from the " + enemyNames[roomEnemy[roomNumber]]);
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
                    Debug.Log("You dealt " + playerAttack + " plus " + playerCritDamage + " damage to the " + enemyNames[roomEnemy[roomNumber]] + " with a critical hit");
                    
                        if (enemyRandomChance < playerArmor && enemyHealth[roomEnemy[roomNumber]] > 0)
                        {
                            Debug.Log("You deflected the " + enemyNames[roomEnemy[roomNumber]] + " attack");
                            
                            
                        }
                        else if (enemyRandomChance > playerArmor && enemyHealth[roomEnemy[roomNumber]] > 0)
                        {
                            playerHealth -= enemyAttack[roomEnemy[roomNumber]];
                            
                            Debug.Log("You took " + enemyAttack[roomEnemy[roomNumber]] + " damage from the " + enemyNames[roomEnemy[roomNumber]]);
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

            }
            else if (playerRandomChance > enemyArmor[roomEnemy[roomNumber]])
            {
                if (items[0] == "Sword")
                {
                    enemyHealth[roomEnemy[roomNumber]] -= swordDamageBoost + playerAttack + playerCritDamage;
                    Debug.Log("You dealt " + playerAttack + " plus " + swordDamageBoost + " damage to the " + enemyNames[roomEnemy[roomNumber]] + " with a critical hit");

                    if (enemyRandomChance < playerArmor && enemyHealth[roomEnemy[roomNumber]] > 0)
                    {
                        Debug.Log("You deflected the " + enemyNames[roomEnemy[roomNumber]] + " attack");
                        heavyAttackCounter = heavyAttackCounterMax;
                        
                    }
                    else if (enemyRandomChance > playerArmor && enemyHealth[roomEnemy[roomNumber]] > 0)
                    {
                        playerHealth -= enemyAttack[roomEnemy[roomNumber]];

                        Debug.Log("You took " + enemyAttack[roomEnemy[roomNumber]] + " damage from the " + enemyNames[roomEnemy[roomNumber]]);
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
                    Debug.Log("You dealt " + playerAttack + " damage to the " + enemyNames[roomEnemy[roomNumber]] + " with a critical hit");

                    if (enemyRandomChance < playerArmor && enemyHealth[roomEnemy[roomNumber]] > 0)
                    {
                        Debug.Log("You deflected the " + enemyNames[roomEnemy[roomNumber]] + " attack");
                        heavyAttackCounter = heavyAttackCounterMax;
                        
                    }
                    else if (enemyRandomChance > playerArmor && enemyHealth[roomEnemy[roomNumber]] > 0)
                    {
                        playerHealth -= enemyAttack[roomEnemy[roomNumber]];

                        Debug.Log("You took " + enemyAttack[roomEnemy[roomNumber]] + " damage from the " + enemyNames[roomEnemy[roomNumber]]);
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

            }


        } while (playerHealth > 0 && enemyHealth[roomEnemy[roomNumber]] > 0);



        if (enemyHealth[roomEnemy[roomNumber]] <= 0)
        {
            Debug.Log("You defeated the " + enemyNames[roomEnemy[roomNumber]]);
        }
        else if (playerHealth <= 0)
        {
            Debug.Log("You were defeated by the " + enemyNames[roomEnemy[roomNumber]]);
            playerAlive = false;
        }
//room 3 index 2
        roomNumber += 1;
        Debug.Log("You move into the next room.");
        Debug.Log(roomNames[roomNumber]);
        Debug.Log(roomDescriptions[roomNumber]);
        visitedRooms[roomNumber] = true;
        if (roomNumber % 3 == 0)
        {
            Debug.Log("Room has a red glow");
        }
        Debug.Log("Your boots are filled with water and you lose 1 agility");
        playerAgility -= 1;
        Debug.Log("You now have " + playerAgility + " agility");
        Debug.Log("There is a ogre blocking your path");
        Debug.Log("You attack the ogre");
        if (playerAlive)
        {
            do
            {
                



                int playerRandomChance = Random.Range(1, 6);
                int enemyRandomChance = Random.Range(1, 6);

                if (playerRandomChance < enemyArmor[roomEnemy[roomNumber]])
                {
                    Debug.Log(enemyNames[roomEnemy[roomNumber]] + " armor deflected your attack");

                    if (heavyAttackCounter == 0)
                    {
                        if (enemyRandomChance < playerArmor)
                        {
                            Debug.Log("You deflected the " + enemyNames[roomEnemy[roomNumber]] + " attack");
                            heavyAttackCounter = heavyAttackCounterMax;
                            
                        }
                        else if (enemyRandomChance > playerArmor)
                        {
                            playerHealth -= enemyAttack[roomEnemy[roomNumber]];
                            
                            heavyAttackCounter = heavyAttackCounterMax;
                            
                            Debug.Log("You took " + enemyAttack[roomEnemy[roomNumber]] + " damage from the " + enemyNames[roomEnemy[roomNumber]]);
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

                else if (playerRandomChance > enemyArmor[roomEnemy[roomNumber]] && playerRandomChance >= 4)
                {

                    if (items[0] == "Sword")
                    {
                        enemyHealth[roomEnemy[roomNumber]] -= swordDamageBoost + playerAttack + playerCritDamage;
                        Debug.Log("You dealt " + playerAttack + " plus " + playerCritDamage + "plus" + swordDamageBoost + " damage to the " + enemyNames[roomEnemy[roomNumber]] + " with a critical hit");
                        if (heavyAttackCounter == 0)
                        {
                            if (enemyRandomChance < playerArmor && enemyHealth[roomEnemy[roomNumber]] > 0)
                            {
                                Debug.Log("You deflected the " + enemyNames[roomEnemy[roomNumber]] + " attack");
                                heavyAttackCounter = heavyAttackCounterMax;
                                
                            }
                            else if (enemyRandomChance > playerArmor && enemyHealth[roomEnemy[roomNumber]] > 0)
                            {
                                playerHealth -= enemyAttack[roomEnemy[roomNumber]];
                                
                                heavyAttackCounter = heavyAttackCounterMax;
                                
                                Debug.Log("You took " + enemyAttack[roomEnemy[roomNumber]] + " damage from the " + enemyNames[roomEnemy[roomNumber]]);
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
                    else
                    {
                        Debug.Log("You dealt " + playerAttack + " plus " + playerCritDamage + " damage to the " + enemyNames[roomEnemy[roomNumber]] + " with a critical hit");
                        if (heavyAttackCounter == 0)
                        {
                            if (enemyRandomChance < playerArmor && enemyHealth[roomEnemy[roomNumber]] > 0)
                            {
                                Debug.Log("You deflected the " + enemyNames[roomEnemy[roomNumber]] + " attack");
                                heavyAttackCounter = heavyAttackCounterMax;
                                
                            }
                            else if (enemyRandomChance > playerArmor && enemyHealth[roomEnemy[roomNumber]] > 0)
                            {
                                playerHealth -= enemyAttack[roomEnemy[roomNumber]];
                                
                                heavyAttackCounter = heavyAttackCounterMax;
                                
                                Debug.Log("You took " + enemyAttack[roomEnemy[roomNumber]] + " damage from the " + enemyNames[roomEnemy[roomNumber]]);
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
                }
                else if (playerRandomChance > enemyArmor[roomEnemy[roomNumber]])
                {
                    if (items[0] == "Sword")
                    {
                        enemyHealth[roomEnemy[roomNumber]] -= swordDamageBoost + playerAttack;
                        Debug.Log("You dealt " + playerAttack + " plus " + playerCritDamage + "plus" + swordDamageBoost + " damage to the " + enemyNames[roomEnemy[roomNumber]] + " with a critical hit");
                        if (heavyAttackCounter == 0)
                        {
                            if (enemyRandomChance < playerArmor && enemyHealth[roomEnemy[roomNumber]] > 0)
                            {
                                Debug.Log("You deflected the " + enemyNames[roomEnemy[roomNumber]] + " attack");
                                heavyAttackCounter = heavyAttackCounterMax;
                                
                            }
                            else if (enemyRandomChance > playerArmor && enemyHealth[roomEnemy[roomNumber]] > 0)
                            {
                                playerHealth -= enemyAttack[roomEnemy[roomNumber]];
                                
                                heavyAttackCounter = heavyAttackCounterMax;
                                
                                Debug.Log("You took " + enemyAttack[roomEnemy[roomNumber]] + " damage from the " + enemyNames[roomEnemy[roomNumber]]);
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
                }


            } while (playerHealth > 0 && enemyHealth[roomEnemy[roomNumber]] > 0);
        }



        //room 4 index 3
        if (enemyHealth[roomEnemy[roomNumber]] <= 0)
        {
            roomNumber += 1;
            Debug.Log("You defeated the ogre");
            Debug.Log("You move into the next room.");
            Debug.Log(roomNames[roomNumber]);
            Debug.Log(roomDescriptions[roomNumber]);
            visitedRooms[roomNumber] = true;
            if (roomNumber % 3 == 0)
            {
                Debug.Log("Room has a red glow");
            }
            Debug.Log("You buy a potion from the merchant for 5 gold");

            playerGold -= 5;
            playerPotions += 1;
            items[1] = "Potion";
            Debug.Log("You now have " + playerGold + " gold");
            Debug.Log("You now have " + playerPotions + " potions");

            int playerKeyChance = Random.Range(1, 10);
            if (playerKeyChance <= 3)
            {
                Debug.Log("You walk away and see nothing on the ground");
            }
            else if (playerKeyChance >= 4)
            {
                
                items[3] = "Key";
                Debug.Log("You find a key on the floor");

            }

            Debug.Log("You move into the next room.");
            Debug.Log("you reach a vault door and a long hallway around the vault");
        }
        else if (playerHealth <= 0)
        {
            Debug.Log("You were defeated by the ogre");
            playerAlive = false;
        }


        roomNumber += 1;
        visitedRooms[roomNumber] = true;
        //room 5 index 4
        if (items[3] == "Key" && playerHealth > 0)
        {
            Debug.Log(roomNames[roomNumber]);
            
            if (roomNumber % 3 == 0)
            {
                Debug.Log("Room has a red glow");
            }
            playerGold += roomGold[roomNumber];
            Debug.Log(roomDescriptions[roomNumber]);
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
        }


        //room 6 index 5
        roomNumber += 1;
        Debug.Log(roomNames[roomNumber]);
        Debug.Log(roomDescriptions[roomNumber]);
        visitedRooms[roomNumber] = true;
        if (roomNumber % 3 == 0)
        {
            Debug.Log("Room has a red glow");
        }
        Debug.Log("A spider drops down from the ceiling");
        Debug.Log("You attack the spider");
        if (playerAlive)
        {
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



                int playerRandomChance = Random.Range(1, 6);
                int enemyRandomChance = Random.Range(1, 6);

                if (playerRandomChance < enemyArmor[roomEnemy[roomNumber]])
                {
                    Debug.Log(enemyNames[roomEnemy[roomNumber]] + " armor deflected your attack");

                    if (heavyAttackCounter == 0)
                    {
                        if (enemyRandomChance < playerArmor)
                        {
                            Debug.Log("You deflected the " + enemyNames[roomEnemy[roomNumber]] + " attack");
                            heavyAttackCounter = heavyAttackCounterMax;
                            spiderVenomTaken = false;
                        }
                        else if (enemyRandomChance > playerArmor)
                        {
                            playerHealth -= enemyAttack[roomEnemy[roomNumber]];
                            spiderBite = true;
                            heavyAttackCounter = heavyAttackCounterMax;
                            spiderVenomTaken = false;
                            Debug.Log("You took " + enemyAttack[roomEnemy[roomNumber]] + " damage from the " + enemyNames[roomEnemy[roomNumber]]);
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

                else if (playerRandomChance > enemyArmor[roomEnemy[roomNumber]] && playerRandomChance >= 4)
                {
                    
                    if (items[0] == "Sword")
                    {
                        enemyHealth[roomEnemy[roomNumber]] -= swordDamageBoost + playerAttack + playerCritDamage;
                        Debug.Log("You dealt " + playerAttack + " plus " + playerCritDamage + "plus" + swordDamageBoost + " damage to the " + enemyNames[roomEnemy[roomNumber]] + " with a critical hit");
                        if (heavyAttackCounter == 0)
                        {
                            if (enemyRandomChance < playerArmor && enemyHealth[roomEnemy[roomNumber]] > 0)
                            {
                                Debug.Log("You deflected the " + enemyNames[roomEnemy[roomNumber]] + " attack");
                                heavyAttackCounter = heavyAttackCounterMax;
                                spiderVenomTaken = false;
                            }
                            else if (enemyRandomChance > playerArmor && enemyHealth[roomEnemy[roomNumber]] > 0)
                            {
                                playerHealth -= enemyAttack[roomEnemy[roomNumber]];
                                spiderBite = true;
                                heavyAttackCounter = heavyAttackCounterMax;
                                spiderVenomTaken = false;
                                Debug.Log("You took " + enemyAttack[roomEnemy[roomNumber]] + " damage from the " + enemyNames[roomEnemy[roomNumber]]);
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
                    else
                    {
                        Debug.Log("You dealt " + playerAttack + " plus " + playerCritDamage + " damage to the " + enemyNames[roomEnemy[roomNumber]] + " with a critical hit");
                        if (heavyAttackCounter == 0)
                        {
                            if (enemyRandomChance < playerArmor && enemyHealth[roomEnemy[roomNumber]] > 0)
                            {
                                Debug.Log("You deflected the " + enemyNames[roomEnemy[roomNumber]] + " attack");
                                heavyAttackCounter = heavyAttackCounterMax;
                                spiderVenomTaken = false;
                            }
                            else if (enemyRandomChance > playerArmor && enemyHealth[roomEnemy[roomNumber]] > 0)
                            {
                                playerHealth -= enemyAttack[roomEnemy[roomNumber]];
                                spiderBite = true;
                                heavyAttackCounter = heavyAttackCounterMax;
                                spiderVenomTaken = false;
                                Debug.Log("You took " + enemyAttack[roomEnemy[roomNumber]] + " damage from the " + enemyNames[roomEnemy[roomNumber]]);
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
                }
                else if (playerRandomChance > enemyArmor[roomEnemy[roomNumber]])
                {
                    if (items[0] == "Sword")
                    {
                        enemyHealth[roomEnemy[roomNumber]] -= swordDamageBoost + playerAttack;
                        Debug.Log("You dealt " + playerAttack + " plus " + playerCritDamage + "plus" + swordDamageBoost + " damage to the " + enemyNames[roomEnemy[roomNumber]] + " with a critical hit");
                        if (heavyAttackCounter == 0)
                        {
                            if (enemyRandomChance < playerArmor && enemyHealth[roomEnemy[roomNumber]] > 0)
                            {
                                Debug.Log("You deflected the " + enemyNames[roomEnemy[roomNumber]] + " attack");
                                heavyAttackCounter = heavyAttackCounterMax;
                                spiderVenomTaken = false;
                            }
                            else if (enemyRandomChance > playerArmor && enemyHealth[roomEnemy[roomNumber]] > 0)
                            {
                                playerHealth -= enemyAttack[roomEnemy[roomNumber]];
                                spiderBite = true;
                                heavyAttackCounter = heavyAttackCounterMax;
                                spiderVenomTaken = false;
                                Debug.Log("You took " + enemyAttack[roomEnemy[roomNumber]] + " damage from the " + enemyNames[roomEnemy[roomNumber]]);
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
                }


            } while (playerHealth > 0 && enemyHealth[roomEnemy[roomNumber]] > 0);
        }


        int campfireCounter = 10;
        int campfireHeal = 5;
        if (enemyHealth[roomEnemy[roomNumber]] <= 0)
        {
            Debug.Log("You defeated the spider");
            Debug.Log("You move to the door and exit the dungeon");
            Debug.Log("You find a campfire");
            while (playerHealth <= playerMaxHealth && campfireCounter > 0)
            {

                Debug.Log("You sit at the campfire to regain health and regain 1 health");
                playerHealth += campfireHeal;
                campfireCounter -= 1;
            }
            Debug.Log("You now have " + playerHealth + " health");
        }
        else if (playerHealth <= 0)
        {
            Debug.Log("You were defeated by the spider");
        }
        Debug.Log("Your final inventory");
        Debug.Log("▽ ▽ ▽ ▽ ▽");
        foreach (string item in items)
        {
            Debug.Log(item);
        }
    }
}


//******** ARRAYS *********
// A1: ROOMS INTO ARRAYS. Put your existing room names and descriptions into DONE

//     two arrays (roomNames[i] and roomDescsriptions[i] describe the SAME

//     room). Keep the same rooms you already have (do not add or remove any).

// 

//     Hint: How many elements should be in the roomNames array? What about

//     the roomDescriptions array? Should they be different lengths or the same?



// A2: SHOW THE MAP. At the very start of the game, output every room name with DONE 

//     a single loop (a quick map of the dungeon) using Debug.Log

//

//      Hint: What new type of loop can you use for this that works specifically

//      with containers?



// A3: MOVE BY INDEX. Keep a currentRoom number that starts at 0. Each time the DONE

//     player moves on, add 1 to it and show that room's name and description

//     from the arrays, instead of hand-writing each room's header.



// A4: ONE INVENTORY ARRAY. Replace your separate item flags (hasKey, the DONE

//     sword, the shield, and so on) with a single inventory array. Add an item

//     to it each time the player picks something up.

//

//     Hint: How big does this array need to be? What data type should it be?



// A5: SHOW THE LOOT. At the end of the run, print the player's whole inventory Done



// A6: KEY FROM THE INVENTORY. At the vault door, do not use a hasKey bool. DONE

//     Check whether "key" is in the inventory array to decide if the hero may

//     pass.

//     

//     Hint: How could you use what we've previously learned (loops and ifs) to

//     find if a specific item is in an array?



// A7: COMBAT ITEMS, NOT PERMANENT UPGRADES. Right now picking up the DONE

//     sword or shield permanently raises attack or defense. Stop doing that. Leave the

//     Do not increase the base stats (attack and defense) of the player.

//

//     Instead, INSIDE each fight, check the inventory and apply the appropriate bonus

//     only in the attack and damage calculations. For example:

//     If the hero is carrying the sword, add swordBonus to the attack and damage roll

//     If the hero is carrying the shield, subtract shieldBonus when reducing damage taken



// A8: ENEMIES INTO ARRAYS (the data, not the encounters). Right now each enemy DONE

//     is a pile of separate variables (goblinHealth, goblinAttack, ogreHealth,

//     and so on). Put them into arrays instead (enemyNames[], enemyHealth[],

//     enemyAttack[], enemyArmorClass[] and enemyDefense[]), one array element

//     per enemy (element 0 = goblin, element 1 = ogre, element 2 = spider)

//    Keep each fight in its OWN room and read the enemy from the arrays by index.

//

//     Hint: How many arrays do you need? How many elements per array?



// A9: GOLD BY ROOM. Store the gold each room holds in a roomGold[] array and                          Done

//     total it with a loop, instead of adding gold by hand in each room. As the player

//     walks through each room, add however much gold is in the room to the player's

//     overall gold.

//

//     Hint: How many elements do you need in this array? What should you do if

//     a room doesn't have gold in it?



// A10: ROOM ENEMIES. Create a roomEnemy[] array alongside your room arrays, DONE

//      one slot per room, holding the index of the enemy waiting there (or -1 for none).

//      As currentRoom advances, if roomEnemy[currentRoom] is not -1, run the

//      enemy's fight. This ties each enemy to its room through the arrays.

//

//      Hint: What data type should the roomEnemy array be if it is an array of indexes?



// A11: TRACK VISITED ROOMS: Create a "visited" array of bools, one per room, Done

//      so you can mark the rooms the player has already been through.

//

//      Hint: How big should this array be? What data type should it be? What should

//      the starting values be?



// A12: LOOT TABLE: an array of possible rewards. Print the whole table (or Done

//      pick from it) with a loop instead of writing each reward out by hand. We won't

//      be using this table for anything yet, but add at least three possible rewards.

//      Example rewards could be some kind of healing item, weapon, armor, etc.




