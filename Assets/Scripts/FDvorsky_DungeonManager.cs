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
        int defence = 2;
        int potion = 0;
        int health = 5;
        int attack = 3;
        int agility = 5;
        int gold = 15; 
        bool hasKey = false;
        int goblinHealth = 3;
        int goblinAttack = 1;
        // ===== ALREADY BUILT IN CLASS (Intro lecture): the opening + two rooms =====
        Debug.Log("=== THE DUNGEON ===");
        Debug.Log("Welcome, " + playerName + ". Your escape begins."); // replace Hero with the name of your player.

        Debug.Log("");
        Debug.Log("The Entrance Hall");
        Debug.Log("A torch flickers on the wall. A stone doorway leads north.");
        
        Debug.Log("You move into the next room.");

        Debug.Log("");
        Debug.Log("The Guard Room");
        Debug.Log("A rusty sword rests on a table. A goblin snores in the corner.");
        Debug.Log("You pick up the sword which gives you an extra 2 attack, the goblin wakes up because of the noise");
        attack += 2;
        Debug.Log("You now have " + attack + " attack");
        Debug.Log("The goblin attacks you, it has an attack power of 1");
        health -= (goblinAttack - defence);
        Debug.Log("you have " + health + "health remaining");
        
        Debug.Log("You now attack the goblin");
        goblinHealth -= attack;
        if (goblinHealth >= 0) 
        {
            Debug.Log("Goblin survives, it has " + goblinHealth + " remaining");


        
                

        }
        ;
        if (goblinHealth <= 0)
        {
            Debug.Log("Goblin has been defeated, you can now continue");





        }
        ;
        Debug.Log("You move into the next room.");

        // ======================================================================
        // PART A  -  after the INTRO lecture (Debug.Log only)
        // ======================================================================

        // TODO A1: FIX THE BROKEN ROOM below. It has bugs that stops the program
        //          from running. Un-comment the lines, find the bug(s), fix it,
        //          and add a // comment saying what was wrong.
         Debug.Log("The Flooded Passage");
         Debug.Log("Ankle-deep water fills the hall. A broken door is at the end of the hallway.");
        Debug.Log("Your boots are filled with water and you lose 1 agility");
        agility -= 1;
        Debug.Log("You now have " + agility + " agility");
        Debug.Log("You move into the next room.");

        // TODO A2: write at least one of your OWN room - a Room Name line,
        //          a description line, and a line describing how you exit. 
        Debug.Log("The Dusty Library");
         Debug.Log("The walls are covered in dusty books from floor to ceiling, there is a large door at the end of the room, and a merchant selling potions");
         Debug.Log("You buy a potion from the merchant for 5 gold");
         gold -= 5;
         potion += 1;
         Debug.Log("You now have " + gold + " gold");
        Debug.Log("You now have " + potion + " potions");
        Debug.Log("You move into the next room.");
        // TODO A3: write the EXIT room - a final "room" and description that leads the
        //          player out of the dungeon.
         Debug.Log("Long stair case");
         Debug.Log("A long staircase that leads to a large wooden door");
         Debug.Log("You move to the door and exit the dungeon");
        // ======================================================================
        // PART B  -  after the VARIABLES lecture (variables & operators)
        // ======================================================================

        // TODO B2: FIX THE BROKEN ROOM below. It has bugs that stops the program
        //          from running. Un-comment the lines, find the bug(s), fix it,
        //          and add a // comment saying what was wrong.
         
         Debug.Log("The Treasure Room");
         gold += 5000;
         Debug.Log("It seems this room has been raided. You find " + 5000 + " gold.");
         Debug.Log("You now have " + gold + " gold");
         Debug.Log("You move into the next room.");
         
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