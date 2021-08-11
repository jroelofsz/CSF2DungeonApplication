using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Room
    {

        public static string RoomGet()
        {
            string[] rooms =
        {
            "This room is hung with hundreds of dusty tapestries. All show signs of wear: moth holes, scorch marks, dark stains, and the damage of years of neglect. They hang on all the walls and hang from the ceiling to brush against the floor, blocking your view of the rest of the room.",
            "Neither light nor darkvision can penetrate the gloom in this chamber. An unnatural shade fills it, and the room's farthest reaches are barely visible. Near the room's center, you can just barely perceive a lump about the size of a human lying on the floor. (It might be a dead body, a pile of rags, or a sleeping monster that can take advantage of the room's darkness.)",
            "You smelled smoke as you moved down the hall, and rounding the corner into this room you see why. Every surface bears scorch marks and ash piles on the floor. The room reeks of fire and burnt flesh. Either a great battle happened here or the room bears some fire danger you cannot see for no flames light the room anymore.",
            "You open the door, and the room comes alive with light and music. A sourceless, warm glow suffuses the chamber, and a harp you cannot see plays soothing sounds. Unfortunately, the rest of the chamber isn't so inviting. The floor is strewn with the smashed remains of rotting furniture. It looks like the room once held a bed, a desk, a chest, and a chair.",
            "This small room is lined with benchlike seats on all the walls. The seats all have holes in their top, like a privy. Facing stones on the front of the benches prevent you from seeing how deep the holes go. It looks like a communal bathroom.",
            "A stone throne stands on a foot-high circular dais in the center of this cold chamber. The throne and dais bear the simple adornments of patterns of crossed lines -- a pattern also employed around each door to the room.",
            "Three low, oblong piles of rubble lie near the center of this small room. Each has a weapon jutting upright from one end -- a longsword, a spear, and a quarterstaff. The piles resemble cairns used to bury dead adventurers.",
            "Several exits lead from this room, but only one is within the mouth of a man. The door opposite you stands within an intricate stone carving of a man's wide-open mouth. The man's nose and eyes loom over the door while his sculpted hair splays out across the wall on either side.",
            "Rats inside the room shriek when they hear the door open, then they run in all directions from a putrid corpse lying in the center of the floor. As these creatures crowd around the edges of the room, seeking to crawl through a hole in one corner, they fight one another. The stinking corpse in the middle of the room looks human, but the damage both time and the rats have wrought are enough to make determining its race by appearance an extremely difficult task at best.",
            "The strong, sour-sweet scent of vinegar assaults your nose as you enter this room. Sundered casks and broken bottle glass line the walls of this room. Clearly this was someone's wine cellar for a time. The shards of glass are somewhat dusty, and the spilled wine is nothing more than a sticky residue in some places. Only one small barrel remains unbroken amid the rubbish.",
            "Burning torches in iron sconces line the walls of this room, lighting it brilliantly. At the room's center lies a squat stone altar, its top covered in recently spilled blood. A channel in the altar funnels the blood down its side to the floor where it fills grooves in the floor that trace some kind of pattern or symbol around the altar. Unfortunately, you can't tell what it is from your vantage point.",
            "A pungent, earthy odor greets you as you pull open the door and peer into this room. Mushrooms grow in clusters of hundreds all over the floor. Looking into the room is like looking down on a forest. Tall tangles of fungus resemble forested hills, the barren floor looks like a plain between the woods, and even a trickle of water and a puddle of water that pools in a low spot bears a resemblance to a river and lake, respectively.",
            "Several round pits lie in the floor of the room before you. Spaced roughly equally apart, each is about 15 feet in diameter and appears about 20 feet deep. A lattice of thick iron bars covers the top of each pit, and each lattice has a door of iron bars that can be lifted open. The pits smell of sweat and offal, but the room seems unoccupied.",
            "You open the door and a gout of flame rushes at your face. A wave of heat strikes you at the same time and light fills the hall. The room beyond the door is ablaze! An inferno engulfs the place, clinging to bare rock and burning without fuel.",
            "A glow escapes this room through its open doorways. The masonry between every stone emanates an unnatural orange radiance. Glancing quickly about the room, you note that each stone bears the carving of someone's name."
        };

            return rooms[new Random().Next(rooms.Length)];
        }
        
    }
}
