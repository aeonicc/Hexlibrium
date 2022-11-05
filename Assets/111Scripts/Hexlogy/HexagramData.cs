using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace HEXLIBRIUM
{
    public class HexagramData : MonoBehaviour
    {
        public static HexagramData instance;
        
        public GameObject[] H64;
        
        public static int[] hexagramPrimeNumber = new int[64];
        
        public static int[,] bigramDataMatrix = new int[2,8];
        public static int[,,] trigramDataMatrix = new int[2,2,2];
        public static int[,,,,,] hexagramDataMatrix = new int[2,2,2,2,2,2];
        
        

        public static int hexagramLineCount = 0;
        public enum HexagramEnumLines : int
        { 
            L00 ,
            L01 ,
            L02 ,
            L03 ,
            L04 ,
            L05 ,
            L06 ,
            L07 ,
        }

        public HexagramEnumLines hexagramEnumLines = HexagramEnumLines.L00;

       // HexagramEnumFunction(  );
       
        public static HexagramEnumLines HexagramEnumFunction(HexagramEnumLines hex)
        {
            
            return hex;
        }
        
        // public int L00 { get; protected set; }
        // public int L01 { get; protected set; }
        // public int L02 { get; protected set; }
        // public int L03 { get; protected set; }
        // public int L04 { get; protected set; }
        // public int L05 { get; protected set; }
        // public int L06 { get; protected set; }
        //public int L07 { get; protected set; }
        
        public static List<int> hexagramList = new List<int>();

        public static string[,,] hexagramStringData = new string[64, 2, 6]
        {
            
            {
                {
                "1 1 1 1 1 1",
                " ䷀ (乾 qián) ", 
                " Force", 
                "The Creative",
                " Possessing Creative Power & Skill",
                "Heaven above and Heaven below: Heaven in constant motion. With the strength of the dragon, the Superior Person steels herself for ceaseless activity. Productive activity. Potent Influence. Sublime success if you keep to your course."
                },
                {
                "The dragon remains beneath the surface. Do not act.",
                "The dragon climbs to the surface. Seek advice from an authority you respect.",
                "The Superior Person builds by day and remains vigilant through the night. Danger, but she will persevere.",
                "The flying dragon hovers over the chasm from which she was born.",
                "The dragon rises high for all to see. She has become the mentor she always longed to find.",
                "Even a dragon may fly too high."}
            },
            {
                {
                "0 0 0 0 0 0",
                " ䷁ (坤 kūn) ",
                " Field",
                "The Receptive",
                " Needing Knowledge & Skill; Do not force matters and go with the flow",
                "Earth above and Earth below: The Earth contains and sustains. In this situation The Superior Person should not take the initiative; she should follow the initiative of another. She should seek receptive allies in the southwest; she should break ties with immovable allies in the northeast. Responsive devotion. Receptive influence. Sublime success if you keep to your course."
                },{"0","0","0","0","0","0"}
            },
            {
                {
                "1 0 0 0 1 0", 
                " 03",
                " Sprouting ",
                "䷂ (屯 zhūn)",
                " Sprouting, Difficulty at the Beginning",
                " Thunder from the Deep: The Superior Person carefully weaves order out of confusion. Supreme success if you keep to your course. Carefully consider the first move. Seek help. "
                },{"0","0","0","0","0","0"}
                },
            {
                {
                "0 1 0 0 0 1", 
                " 04", 
                " ䷃ (蒙 méng)", 
                " Enveloping, Youthful Folly", 
                " Detained,  Enveloped and Inexperienced", 
                "A fresh Spring at the foot of the Mountain: The Superior Person refines her character by being thorough in every activity. The sage does not recruit students; the students seek her. She asks nothing but a sincere desire to learn. If the student doubts or challenges her authority,  the sage regretfully cuts her losses. Success if you are sincerely firm."
            },{"0","0","0","0","0","0"}
            }, 
            {
                {
                "1 1 1 0 1 0", 
                " 05", 
                " ䷄ (需 xū)", 
                " Waiting, Attending", 
                " Uninvolvement (Wait for now),  Nourishment", 
               " Deep Waters in the Heavens: Thunderclouds approaching from the west,  but no rain yet. The Superior Person nourishes herself and remains of good cheer to condition herself for the moment of truth. Great success if you sincerely keep to your course. You may cross to the far shore. "
                },{"0","0","0","0","0","0"}
                
            }, 
            {
            {
                "0 1 0 1 1 1",
                " Arguing ", 
                "䷅(訟 sòng)", 
                " Conflict", 
                " Engagement in Conflict", 
                
                " The high Heavens over a yawning Deep chasm: an expansive void where nothing can dwell. Even though she sincerely knows she is right,  the Superior Person anticipates opposition and carefully prepares for any incident. Good fortune if your conflict results in compromise. Misfortune if your conflict escalates to confrontation. Seek advice. Postpone your crossing to the far shore. "
            },{"0","0","0","0","0","0"}}, 
            {
            {
                "0 1 0 0 0 0", 
                
                " Leading ", 
                "䷆(師 shī)", 
                " The Army", 
                " Bringing Together,  Teamwork", 
            
                " Deep Water beneath the Earth's surface: Untapped resources are available. The Superior Person nourishes and instructs the people,  building a loyal,  disciplined following. Good fortune. No mistakes if you follow a course led by experience. "
            },{"0","0","0","0","0","0"}}, 
            {
            {
                "0 0 0 0 1 0", 
                
                " Grouping ", 
                "䷇(比 bǐ)", 
                " Holding Together", 
                " Union", 
          
                " Deep waters on the face of the Earth: Surface Waters flow together. The Superior Person recognizes the situation calls for joining together. Thus she cultivates friendly relations with all. Good fortune is possible. Cast the coins again to discover if you have the qualities needed to lead such a group. Then there will be no error. Those uncertain will gradually join. Those who join too late will meet with misfortune. "
            },{"0","0","0","0","0","0"}}, 
            {
            {
                "1 1 1 0 1 1", 
                
                " Small Accumulating ", 
                "䷈(小畜 xiǎo chù)", 
                " Small Taming", 
                " Accumulating Resources", 
        
                " Winds of change high in the Heavens: Air currents carry the weather. Dense clouds blow in from the west,  but still no rain. The Superior Person fine tunes the image she presents to the world. Small successes."
            },{"0","0","0","0","0","0"}}, 
            {
            {
                "1 1 0 1 1 1", 
               
                " Treading ", 
                "䷉(履 lǚ)", 
                " Treading (Conduct)", 
                " Continuing with Alertness", 
              
                " Heaven shines down on the Marsh which reflects it back imperfectly: Though the Superior Person carefully discriminates between high and low,  and acts in accord with the flow of the Tao,  there are still situations where a risk must be taken. You tread upon the tail of the tiger. Not perceiving you as a threat,  the startled tiger does not bite. Success."
            },{"0","0","0","0","0","0"}}, 
            {
            {
                "1 1 1 0 0 0", 
                
                " Pervading ", 
                "䷊(泰 tài)", 
                " Peace", 
                " Pervading", 
          
                "Heaven and Earth embrace,  giving birth to Peace. The Superior Person serves as midwife,  presenting the newborn gift to the people. The small depart; the great approach. Success. Good fortune."
            },{"0","0","0","0","0","0"}}, 
            {
            {
                "0 0 0 1 1 1",
                " Obstruction ", 
                "䷋(否 pǐ)", 
                " Standstill", 
                "Stagnation", 
           
                "Heaven and Earth move away from each other. In the ensuing void,  the small invade where the great have departed. There is no common meeting ground,  so the Superior Person must fall back on her inner worth and decline the rewards offered by the inferior invaders. Difficult trials as you hold to your course."
            },{"0","0","0","0","0","0"}}, 
            {
            {
                "1 0 1 1 1 1",
                " Concording People ", 
                "䷌(同人 tóng rén)", 
                " Fellowship", 
                " Fellowship,  Partnership", 
            
                "Heaven reflects the Flame of clarity: The Superior Person analyzes the various levels and working parts of the social structure,  and uses them to advantage. Success if you keep to your course. You may cross to the far shore."
            },{"0","0","0","0","0","0"}}, 
            {
            {
                "1 1 1 1 0 1",
                " Great Possessing ", 
                "䷍(大有 dà yǒu)", 
                " Great Possession", 
                " Independence,  Freedom", 
         
                "The Fire of clarity illuminates the Heavens to those below: The Superior Person possesses great inner treasures -- compassion,  economy,  and modesty. These treasures allow the benevolent will of Heaven to flow through her outward to curb evil and further good. Supreme success."
            },{"0","0","0","0","0","0"}}, 
            {
            {
                "0 0 1 0 0 0",
                " Humbling ", 
                "䷎(謙 qiān)", 
                " Modesty", 
                " Being Reserved,  Refraining", 
           
                "The Mountain does not overshadow the Plain surrounding it: Such modest consideration in a Superior Person creates a channel through which excess flows to the needy. Success if you carry things through.", 
            },{"0","0","0","0","0","0"}}, 
            {
            {
                "0 0 0 1 0 0",
                " Providing-For ", 
                "䷏(豫 yù)", 
                " Enthusiasm", 
                " Inducement,  New Stimulus", 
          
                " Thunder comes resounding out of the Earth: Similar thunder roars up from the masses when the Superior Person strikes a chord in their hearts. Whip up enthusiasm,  rally your forces,  and move boldly forward."
            },{"0","0","0","0","0","0"}}, 
            {
            {
                "1 0 0 1 1 0",
                " Following ", 
                "䷐(隨 suí)", 
                " Following", 
                " Following", 
         
                "Thunder beneath the Lake's surface. The Superior Person allows herself plenty of sheltered rest and recuperation while awaiting a clear sign to follow. Supreme success. No mistakes if you keep to your course."
            },{"0","0","0","0","0","0"}}, 
            {
            {
                "0 1 1 0 0 1",
                " Corrupting ",
                "䷑(蠱 gǔ)",
                " Work on the Decayed",
                " Repairing",
             
                " Winds sweep through the Mountain valley: The Superior Person sweeps away corruption and stagnation by stirring up the people and strengthening their spirit. Supreme success. Before crossing to the far shore, consider the move for three days. After crossing, devote three days of hard labor to damage control."
            },{"0","0","0","0","0","0"}},
            {
            {
                "1 1 0 0 0 0",
                " Nearing ",
                "䷒(臨 lín)",
                " Approach",
                " Approaching Goal, Arriving ",
              
                "The rich, loamy Earth on the banks of the Marsh provides fertile soil for exceptional progress. The Superior Person is inexhaustible in her willingness to teach, and without limit in her tolerance and support of others. Supreme success if you keep to your course. But be aware that your time is limited; Your power will wane, as Summer changes to Fall."
            },{"0","0","0","0","0","0"}},
            {
            {
                "0 0 0 0 1 1",
                " Viewing ",
                "䷓(觀 guān)",
                " Contemplation",
                " The Withholding",
             
                " The gentle Wind roams the Earth: The Superior Person expands her sphere of influence as she expands her awareness. Deeply devoted to her pursuit of clarity and wisdom, she is unconscious of the inspiring, positive example she is setting for others to emulate. You have cleansed yourself; now stand ready to make your humble, devout offering."
            },{"0","0","0","0","0","0"}},
            {
            {
                "1 0 0 1 0 1",
                " Gnawing Bite",
                " ䷔(噬嗑 shì kè)",
                " Biting Through",
                " Deciding",
           
                " The merciless, searing judgement of Lightning fulfills the warning prophecies of distant Thunder. Sage rulers preserved justice by clearly defining the laws, and by delivering the penalties decreed. Though unpleasant, it is best to let justice have its due."
            },{"0","0","0","0","0","0"}},
            {
            {
                "1 0 1 0 0 1",
                " Adorning ",
                "䷕(賁 bì)",
                " Grace",
                " Embellishing",
         
                " Fire illuminates the base of the Mountain: The Superior Person realizes she has not the wisdom to move the course of the world, except by attending to each day's affairs as they come. Success in small matters. This is a good time to begin something."
            },{"0","0","0","0","0","0"}},
            {
            {
                "0 0 0 0 0 1",
                " Stripping",
                "䷖(剝 bō)",
                " Splitting Apart",
                " Stripping, Flaying",
         
                " The weight of the Mountain presses down upon a weak foundation of Earth: The Superior Person will use this time of oppression to attend to the needs of those less fortunate. Any action would be ill-timed. Stand fast."
            },{"0","0","0","0","0","0"}},
            {
            {
                "1 0 0 0 0 0",
                " Returning ",
                "䷗(復 fù)",
                " Return",
                " Returning",
           
                " Thunder regenerates deep within Earth's womb: Sage rulers recognized that the end of Earth's seasonal cycle was also the starting point of a new year and a time for dormancy. They closed the passes at the Solstice to enforce a rest from commerce and activity. The ruler herself did not travel. You have passed this way before but you are not regressing. This is progress, for the cycle now repeats itself, and this time you are aware that it truly is a cycle. The return of old familiars is welcome. You can be as sure of this cycle as you are that seven days bring the start of a new week. Use this dormancy phase to plan which direction you will grow."
            },{"0","0","0","0","0","0"}},
            {
            {
                "1 0 0 1 1 1",
                " Without Embroiling ",
                "䷘(無妄 wú wàng)",
                " Innocence",
                " Without Rashness",
         
                " Thunder rolls beneath Heaven, as is its nature and place: Sage rulers aligned themselves with the changing seasons, nurturing and guiding their subjects to do the same. Exceptional progress if you are mindful to keep out of the way of the natural Flow. It would be a fatal error to try to alter its course. This is a time of Being, not Doing."
            },{"0","0","0","0","0","0"}},
            {
            {
                "1 1 1 0 0 1",
                " Great Accumulating ",
                "䷙(大畜 dà chù)",
                " Great Taming",
                " Accumulating Wisdom",
          
                " Heaven's motherlode waits within the Mountain: The Superior Person mines deep into history's wealth of wisdom and deeds, charging her character with timeless strength. Persevere. Drawing sustenance from these sources creates good fortune. Then you may cross to the far shore."
            },{"0","0","0","0","0","0"}},
            {
            {
                "1 0 0 0 0 1",
                " Swallowing ",
                "䷚(頤 yí)",
                " Mouth Corners",
                " Seeking Nourishment",
         
                " Beneath the immobile Mountain the arousing Thunder stirs: The Superior Person preserves her freedom under oppressive conditions by watching what comes out of her mouth, as well as what goes in. Endure and good fortune will come. Nurture others in need, as if you were feeding yourself. Take care not to provide sustenance for those who feed off others. Stay as high as possible on the food chain."
            },{"0","0","0","0","0","0"}},
            {
            {
                "0 1 1 1 1 0",
                " Great Exceeding ",
                "䷛(大過 dà guò)",
                " Great Preponderance",
                " Great Surpassing",
           
                " The Flood rises above the tallest Tree: Amidst a rising tide of human folly, the Superior Person retires to higher ground, renouncing her world without looking back. Any direction is better than where you now stand."
            },{"0","0","0","0","0","0"}},
            {
                {
                "0 1 0 0 1 0",
                " Gorge ",
                "䷜(坎 kǎn)",
                " The Abysmal Water",
                " Darkness, Gorge",
       
                " Water follows Water, spilling over any cliff, flowing past all obstacles, no matter the depth or distance, to the sea. The Superior Person learns flexibility from the mistakes she has made, and grows strong from the obstacles she has overcome, pressing on to show others the Way."
            },{"0","0","0","0","0","0"}
            
        },
            {
                {
                "1 0 1 1 0 1",
                " Radiance",
                "䷝ (離 lí)",
                " The Clinging; Clinging",
                " Attachment",
             
                " Fire sparks more Flames: The Superior Person holds an inner Fire that ignites passion in every heart it touches, until all the world is enlightened and aflame. With so searing a flame, success will not be denied you. Take care to be as peaceful and nurturing as the cow in the meadow; you are strong enough to be gentle."
            },{"0","0","0","0","0","0"}
            
        },
            {
                {
                "0 0 1 1 1 0",
                " Conjoining ",
                "䷞(咸 xián)",
                " Influence",
                " Attraction",
           
                " The joyous Lake is cradled by the tranquil Mountain: The Superior Person takes great satisfaction in encouraging others along their journey. She draws them to her with her welcoming nature and genuine interest. Supreme success. This course leads to marriage."
            },{"0","0","0","0","0","0"}
            
        },
            {
                {
                "0 1 1 1 0 0",
                " Persevering ",
                "䷟(恆 héng)",
                " Duration",
                " Perseverance",
               
                " Arousing Thunder and penetrating Wind, close companions in any storm: The Superior Person possesses a resiliency and durability that lets her remain firmly and faithfully on course. Such constancy deserves success."
            },{"0","0","0","0","0","0"}
            
        },
            {
                {
                "0 0 1 1 1 1",
                " Retiring ",
                "䷠(遯 dùn)",
                " Retreat",
                " Withdrawing",
             
                " The tranquil Mountain towers overhead, yet remains this side of Heaven: The Superior Person avoids the petty and superficial by keeping shallow men at a distance, not in anger but with dignity. Such a retreat sweeps the path clear to Success. Occupy yourself with minute detail."
            },{"0","0","0","0","0","0"}
            
        },
            {
                {
                "1 1 1 1 0 0",
                " Great Invigorating ",
                "䷡(大壯 dà zhuàng)",
                " Great Power",
                " Great Boldness",
           
                " Thunder fills the Heavens with its awful roar, not out of pride, but with integrity; if it did less, it would not be Thunder: Because of her Great Power, the Superior Person takes pains not to overstep her position, so that she will not seem intimidating or threatening to the Established Order. Opportunity will arise along this course."
            },{"0","0","0","0","0","0"}
            
        },
            {
                {
                "0 0 0 1 0 1",
                " Prospering ",
                "䷢(晉 jìn)",
                " Progress",
                " Expansion, Promotion",
           
                " The Sun shines down upon the Earth: Constantly honing and refining her brilliance, the Superior Person is a Godsend to her people. They repay her benevolence with a herd of horses, and she is granted audience three times in a single day. Promotion."
            },{"0","0","0","0","0","0"}
            
        },
            {
                {
                "1 0 1 0 0 0",
                " Brightness Hiding ",
                "䷣(明夷 míng yí)",
                " Darkening of the Light",
                " Brilliance Injured",
           
                " Warmth and Light are swallowed by deep Darkness: The Superior Person shows her brilliance by keeping it veiled among the masses. Stay true to your course, despite the visible obstacles ahead."
            },{"0","0","0","0","0","0"}
            
        },
            {
                {
                "1 0 1 0 1 1",
                " Dwelling People ",
                " ䷤(家人 jiā rén)",
                " The Family",
                " Family",
         
                " Warming Air Currents rise and spread from the Hearthfire: The Superior Person weighs her words carefully and is consistent in her behavior. Be as faithful as a good wife."
            },{"0","0","0","0","0","0"}
            
        },
            {
                {
                "1 1 0 1 0 1",
                " Polarising ",
                "䷥(睽 kuí)",
                " Opposition",
                " Division, Divergence",
            
                " Fire distances itself from its nemesis, the Lake: No matter how large or diverse the group, the Superior Person remains uniquely herself. Small accomplishments are possible."
            },{"0","0","0","0","0","0"}
            
        },
            {
                {
                "0 0 1 0 1 0",
                " Limping ",
                "䷦(蹇 jiǎn)",
                " Obstruction",
                " Halting, Hardship",
             
                " Ominous roiling in the Crater Lake atop the Volcano: When meeting an impasse, the Superior Person turns her gaze within, and views the obstacle from a new perspective. Offer your opponent nothing to resist. Let a sage guide you in this. Good fortune lies along this course."
            },{"0","0","0","0","0","0"}
            
        },
            {
                {
                "0 1 0 1 0 0",
                " Taking-Apart ",
                "䷧(解 xiè)",
                " Deliverance",
                " Liberation, Solution",
             
                " A Thunderous Cloudburst shatters the oppressive humidity: The Superior Person knows the release in forgiveness, pardoning the faults of others and dealing gently with those who sin against her. It pays to accept things as they are for now. If there is nothing else to be gained, a return brings good fortune. If there is something yet to be gained, act on it at once."
            },{"0","0","0","0","0","0"}
            
        },
            {
                {
                "1 1 0 0 0 1",
                " Diminishing ",
                "䷨(損 sǔn)",
                " Decrease",
                " Decrease",
             
                " The stoic Mountain drains its excess waters to the Lake below: The Superior Person curbs her anger and sheds her desires. To be frugal and content is to possess immeasurable wealth within. Nothing of value could be refused such a person. Make a portion of each meal a share of your offering."
            },{"0","0","0","0","0","0"}
            
        },
            {
                {
                "1 0 0 0 1 1",
                " Augmenting ",
                "䷩(益 yì)",
                " Increase",
                " Increase",
             
                " Whirlwinds and Thunder: When the Superior Person encounters saintly behavior, she adopts it; when she encounters a fault within, she transforms it. Progress in every endeavor. You may cross to the far shore."
            },{"0","0","0","0","0","0"}
            
        },
            {
                {
                "1 1 1 1 1 0",
                " Parting",
                "䷪(夬 guài)",
                " Breakthrough",
                " Separation",
             
                " A Deluge from Heaven: The Superior Person rains fortune upon those in need, then moves on with no thought of the good she does. The issue must be raised before an impartial authority. Be sincere and earnest, despite the danger. Do not try to force the outcome, but seek support where needed. Set a clear goal."
            },{"0","0","0","0","0","0"}
            
        },
            {
                {
                "0 1 1 1 1 1",
                " Coupling ",
                "䷫(姤 gòu)",
                " Coming to Meet",
                " Encountering",
               
                " A playful Zephyr dances and delights beneath indulgent Heaven: A Prince who shouts orders but will not walk among her people may as well try to command the four winds. A strong, addictive temptation, much more dangerous than it seems."
            },{"0","0","0","0","0","0"}
            
        },
            {
                {
                "0 0 0 1 1 0",
                " Clustering",
                " ䷬(萃 cuì)",
                " Gathering Together",
                " Association, Companionship",
              
                " The Lake rises by welcoming and receiving Earth's waters: The King approaches her temple. It is wise to seek audience with her there. Success follows this course. Making an offering will seal your good fortune. A goal will be realized now."
            },{"0","0","0","0","0","0"}
            
        },
            {
                {
                "0 1 1 0 0 0",
                " Ascending ",
                "䷭(升 shēng)",
                " Pushing Upward",
                " Growing Upward",
            
                " Beneath the Soil, the Seedling pushes upward toward the light: To preserve her integrity, the Superior Person contents herself with small gains that eventually lead to great accomplishment. Supreme success. Have no doubts. Seek guidance from someone you respect. A constant move toward greater clarity will bring reward."
            },{"0","0","0","0","0","0"}
            
        },
            {
                {
                "0 1 0 1 1 0",
                " Confining ",
                " ䷮(困 kùn)",
                " Oppression",
                " Exhaustion",
           
                " A Dead Sea, its Waters spent eons ago, more deadly than the desert surrounding it: The Superior Person will stake her life and fortune on what she deeply believes. Triumph belongs to those who endure. Trial and tribulation can hone exceptional character to a razor edge that slices deftly through every challenge. Action prevails where words will fail."
            },{"0","0","0","0","0","0"}
            
        },
            {
                {
                "0 1 1 0 1 0",
                " Welling ",
                "䷯(井 jǐng)",
                " The Well",
                " Replenishing, Renewal",
            
                " Deep Waters Penetrated and drawn to the surface: The Superior Person refreshes the people with constant encouragement to help one another. Encampments, settlements, walled cities, whole empires may rise and fall, yet the Well at the center endures, never drying to dust, never overflowing. It served those before and will serve those after. Again and again you may draw from the Well, but if the bucket breaks or the rope is too short there will be misfortune."
            },{"0","0","0","0","0","0"}
            
        },
            {
                {
                "1 0 1 1 1 0",
                " Skinning ",
                "䷰(革 gé)",
                " Revolution",
                " Abolishing the Old",
         
                " Fire ignites within the Lake, defying conditions that would deny it birth or survival: The Superior Person reads the Signs of the Times and makes the Season apparent to all. The support you need will come only after the deed is done. Renewed forces, however, will provide fresh energy for exceptional progress. Persevere. All differences vanish."
            },{"0","0","0","0","0","0"}
            
        },
            {
                {
                "0 1 1 1 0 1",
                " Holding ",
                "䷱(鼎 dǐng)",
                " The Cauldron",
                " Establishing the New",
           
                " Fire rises hot and bright from the Wood beneath the sacrificial caldron: The Superior Person positions herself correctly within the flow of Cosmic forces. Supreme accomplishment."
            },{"0","0","0","0","0","0"}
            
        },
            {
                {
                "1 0 0 1 0 0",
                " Shake ",
                "䷲(震 zhèn)",
                " Arousing",
                " Mobilizing",
          
                " Thunder echoes upon Thunder, commanding reverence for its father Heaven: In awe of Heaven's majestic power, the Superior Person looks within and sets her life in order. Thunder mingles with startled screams of terror for a hundred miles around. As the people nervously laugh at their own fright, the devout presents the sacrificial chalice with nary a drop of wine spilt. Deliverance."
            },{"0","0","0","0","0","0"}
            
        },
            {
                {
                "0 0 1 0 0 1",
                " Bound ",
                "䷳(艮 gèn)",
                " The Keeping Still",
                " Immobility",
           
                " Above this Mountain's summit another more majestic rises: The Superior Person is mindful to keep her thoughts in the here and now. Stilling the sensations of the Ego, she roams her courtyard without moving a muscle, unencumbered by the fears and desires of her fellows. This is no mistake."
            },{"0","0","0","0","0","0"}
            
        },
            {
                {
                "0 0 1 0 1 1",
                " Infiltrating ",
                "䷴(漸 jiàn)",
                " Development",
                " Auspicious Outlook, Infiltration",
               
                " The gnarled Pine grows tenaciously off the Cliff face: The Superior Person clings faithfully to dignity and integrity, thus elevating the Collective Spirit of Person in her own small way. Development. The maiden is given in marriage. Good fortune if you stay on course."
            },{"0","0","0","0","0","0"}
            
        },
            {
                {
                "1 1 0 1 0 0",
                " Converting The Maiden ",
                "䷵(歸妹 guī mèi)",
                " The Marrying Maiden",
                " Marrying",
             
                " The Thunderstorm inseminates the swelling Lake, then moves on where the Lake cannot follow: The Superior Person views passing trials in the light of Eternal Truths. Any action will prove unfortunate. Nothing furthers."
            },{"0","0","0","0","0","0"}
            
        },
            {
                {
                "1 0 1 1 0 0",
                " Abounding ",
                "䷶(豐 fēng)",
                " Abundance",
                " Goal Reached, Ambition Achieved",
             
                " Thunder and Lightning from the dark heart of the storm: The Superior Person judges fairly, so that consequences are just. The leader reaches her peak and doesn't lament the descent before her. Be like the noonday sun at its zenith. This is success."
            },{"0","0","0","0","0","0"}
            
        },
            {
                {
                "0 0 1 1 0 1",
                " Sojourning ",
                "䷷(旅 lǚ)",
                " The Wanderer",
                " Travel",
         
                " Fire on the Mountain, catastrophic to man, a passing annoyance to the Mountain: The Superior Person waits for wisdom and clarity before exacting Justice, then lets no protest sway her. Find satisfaction in small gains. To move constantly forward is good fortune to a Wanderer."
            },{"0","0","0","0","0","0"}
            
        },
            {
                {
                "0 1 1 0 1 1",
                " Ground ",
                "䷸(巽 xùn)",
                " The Gentle",
                " Subtle Influence",
             
                " Wind follows upon wind, wandering the earth, penetrating gently but persistently: The Superior Person expands her influence by reaffirming her decisions and carrying out her promises. Small, persistent, focused effort brings success. Seek advice from someone you respect."
            },{"0","0","0","0","0","0"}
            
        },
            {
                {
                "1 1 0 1 1 0",
                " Open ",
                "䷺(兌 duì)",
                " The Joyous",
                " Overt Influence",
            
                " The joyous Lake spans on and on to the horizon: The Superior Person renews and expands her Spirit through heart-to-heart exchanges with others. Success if you stay on course."
            },{"0","0","0","0","0","0"}
            
        },
            {
                {
                "0 1 0 0 1 1",
                " Dispersing",
                " (渙 huàn)",
                " Dispersion",
                " Dispersal",
              
                " Wind carries the Mists aloft: Sage rulers dedicated their lives to serving a Higher Power and built temples that still endure. The King approaches her temple. Success if you stay on course. You may cross to the far shore."
            },{"0","0","0","0","0","0"}
            
        },
            {
                {
                "1 1 0 0 1 0",
                " Articulating ",
                "䷻(節 jié)",
                " Limitation",
                " Discipline",
             
                " Waters difficult to keep within the Lake's banks: The Superior Person examines the nature of virtue and makes herself a standard that can be followed. Self-discipline brings success; but restraints too binding bring self-defeat."
            },{"0","0","0","0","0","0"}
            
        },
            {
                {
                "1 1 0 0 1 1",
                " Centre Confirming ",
                "䷼(中孚 zhōng fú)",
                " Inner Truth",
                " Staying Focused,Avoid Misrepresentation",
              
                " The gentle Wind ripples the Lake's surface: The Superior Person finds common ground between points of contention, wearing away rigid perspectives that would lead to fatal error. Pigs and fishes. You may cross to the far shore. Great fortune if you stay on course."
            },
                {"0","0","0","0","0","0"}
            
            },
            {
                {
                "0 0 1 1 0 0",
                " Small Exceeding ",
                "䷽(小過 xiǎo guò)",
                " Small Preponderance",
                " Small Surpassing",
              
                " Thunder high on the Mountain, active passivity: The Superior Person is unsurpassed in her ability to remain small. In a time for humility, she is supremely modest. In a time of mourning, she uplifts with somber reverence. In a time of want, she is resourcefully frugal. When a bird flies too high, its song is lost. Rather than push upward now, it is best to remain below. This will bring surprising good fortune, if you keep to your course."
            },{"0","0","0","0","0","0"}
            
        },
            {
                {
                "1 0 1 0 1 0",
                " Already_Fording ",
                " ䷾ (既濟 jì jì)",
                " After Completion",
                " Completion",
                " Boiling Water over open Flame, one might extinguish the other: The Superior Person takes a 360 degree view of the situation and prepares for any contingency. Success in small matters if you stay on course. Early good fortune can end in disorder."
            },{"0","0","0","0","0","0"}
            
            },
            {
                {
                "0 1 0 1 0 1",
                " Not-Yet Fording",
                " ䷿ (未濟 wèi jì)",
                " Before Completion",
                " Incompletion",
                " Fire ascends above the Water: The Superior Person examines the nature of things and keeps each in its proper place. Too anxious the young fox gets her tail wet, just as she completes her crossing. To attain success, be like the woman and not like the fox."
            },{"0","0","0","0","0","0"}}
    };
        
          public static int[] hexagramInt64 = new int[64]
        {
            111111,
            000000,
            100010,
            010001,
            111010,
            010111,
            010000,
            000010,
            111011,
            110111,
            111000,
            000111,
            101111,
            111101,
            001000,
            000100,
            100110,
            011001,
            110000,
            000011,
            100101,
            101001,
            000001,
            100000,
            100111,
            111001,
            100001,
            011110,
            010010,
            101101,
            001110,
            011100,
            001111,
            111100,
            000101,
            101000,
            101011,
            110101,
            001010,
            010100,
            110001,
            100011,
            111110,
            011111,
            000110,
            011000,
            010110,
            011010,
            101110,
            011101,
            100100,
            001001,
            001011,
            110100,
            101100,
            001101,
            011011,
            110110,
            010011,
            110010,
            110011,
            001100,
            101010,
            010101
    };

    public static int[,] hexagramInputArray = new int[3,6]
        {
            {0,0,0,0,0,0},
            {0,0,0,0,0,0},
            {0,0,0,0,0,0}
        };
    
    public static string[] hexagramProcessArray = new string[3]
    {
        "0","0","0"
    };
    public static string[,] hexagramOutputArray = new string[3,6]
        {
            {"0","0","0","0","0","0"},
            {"0","0","0","0","0","0"},
            {"0","0","0","0","0","0"}
        };

    public string[,,] deltahedron = new string[6, 5, 9]
    {
        {
            { "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o" },
        },
        {
            { "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o" },
        },
        {
            { "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o" },
        },
        {
            { "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o" },
        },
        {
            { "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o" },
        },
        {
            { "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o" },
        }
    };

    public string[,,] tetrahedron = new string[4, 4, 6]
    {
        {
            { "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o" }
        },
        {
            { "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o" }
        },
        {
            { "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o" }
        },
        {
            { "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o" }
        }
    };
    
    public string[,,] octahedron = new string[8, 6, 12]
    {
        {
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" }
        },
        {
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" }
        },
        {
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" }
        },
        {
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" }
        },
        {
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" }
        },
        {
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" }
        },
        {
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" }
        },
        {
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" }
        }
    };
    
    public string[,,] icosahedron = new string[12,20,30]
    {
        {
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" }
        },
          {
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" }
        },
            {
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" }
        },
              {
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" }
        },
                {
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" }
        },
                  {
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" }
        },
                    {
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" }
        },
                      {
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" }
        },
                        {
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" }
        },
                          {
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" }
        },
                            {
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" }
        },
                              {
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" },
            { "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o", "o" }
        }
                              
        
    };
        
        //data struct class
        public List<string> numbers = new List<string>();

        private void Awake()
        {
            instance = this;
        }

        void Start()
        {
            numbers.Add("void");

            numbers.Insert(1, "full");

//            Debug.Log(numbers[0]);
            
//            Debug.Log(HMArray[0,1,1]);
            
            // H[0] = 0;
            // H[1] = 0;
            // H[2] = 0;
            // H[3] = 0;
            // H[4] = 0;
            // H[5] = 0;
            // H[6] = 0;
            // H[7] = 0;
            // H[8] = 0;
            // H[9] = 0;

            //H64 = GameObject.FindGameObjectWithTag("Void");

        }

        public void Update()
        {
            
        }
    }
}