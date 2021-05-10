using HappyDog_Api.Models.Configuration.Interfaces;
using HappyDog_Api.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HappyDog_Api.Models.Configuration.Initializers
{
    public class DogInfoInitializer : ITypeInitializer
    {
        public async Task Init(ApplicationContext context)
        {
            string path = "/BreedImages/";
            DogInfo[] dogs = new DogInfo[] {
                new DogInfo(){
                   DogTypeId = context.DogTypes.Where(x => x.Type == "Watchdog").FirstOrDefault().Id,

                   MainPhoto = path + "Mrottweiler.jpg",
                   BigPhoto = path + "Brottweiler.jpg",

                   MainDescription = "The Rottweiler is a born defender and reliable guard with a strong independent character. Smart, serious and endlessly loyal to the owner.",
                   BigDescription = "Rottweilers are serious and energetic brutals, whose main purpose is to serve people. It is from the Rottweilers that the best rescuers and guides are made, ready at any moment to risk their own lives in the name of human salvation. On the street, these muscular beauties are threat and alertness personified. They are energetic, observant and always in control of the situation. However, as soon as the dog returns home, an affectionate sloth wakes up in it, occupying a soft sofa and ready to absorb delicious treats in kilograms.",

                   Breed = "Rottweiler",
                   Country = "Germany",
                   Weight = "♂ ~ 50 kg, ♀ ~ 45 kg",
                   Height = "♂ 61-70 cm, ♀ 56-65 cm",
                   LifeExpectancy = "11-12 Years",

                   Aggressiveness = 4,
                   Molting = 2,
                   Health = 3,
                   Intelligence = 5,
                   Activity = 4,
                   MaintenanceCost = 4,
                   Noise = 3,
                   Training = 5,
                   SecurityQualities = 5,
                   Price = "250-400 $"
                },
                new DogInfo(){
                   DogTypeId = context.DogTypes.Where(x => x.Type == "Watchdog").FirstOrDefault().Id,

                   MainPhoto = path + "Mgermanshepherd.jpg",
                   BigPhoto = path + "Bgermanshepherd.jpg",

                   MainDescription = "The German Shepherd has lived side by side with humans since time immemorial. Today she is one of the most popular and recognizable dog breeds on the planet.",
                   BigDescription = "The German Shepherd is a regular at the top of the rankings for the smartest, most loyal, most trainable pets. The noble \"faces\" of these dogs often appear in news stories, on newspaper pages and even in the title roles of various TV shows. But the main vocation of the Germans is not an acting career, but the maintenance of order. They serve in the police, border and customs units, and assist in search and rescue operations. And at home, representatives of this breed protect the peace and property of the owners, give their owners a lot of positive emotions.",

                   Breed = "German Shepherd",
                   Country = "Germany",
                   Weight = "♂ 30-40 kg, ♀ 22-32 kg",
                   Height = "♂ 60-65 cm, ♀ 55-60 cm",
                   LifeExpectancy = "10-13 Years",

                   Aggressiveness = 3,
                   Molting = 5,
                   Health = 3,
                   Intelligence = 5,
                   Activity = 5,
                   MaintenanceCost = 4,
                   Noise = 3,
                   Training = 5,
                   SecurityQualities = 5,
                   Price = "300-900 $"
                },
                new DogInfo(){
                   DogTypeId = context.DogTypes.Where(x => x.Type == "Watchdog").FirstOrDefault().Id,

                   MainPhoto = path + "Mcanecorso.jpg",
                   BigPhoto = path + "Bcanecorso.jpg",

                   MainDescription = "Cane Corso is a large breed, a descendant of the fighting dogs of Ancient Rome. For centuries, these intelligent and obedient dogs have served their masters, guarding their homes, helping on the hunt and in the field.",
                   BigDescription = $"Modern Cane Corso are descendants of gladiator dogs, they breathe with natural strength and greatness. They look harsh, they can even inspire fear, but in fact they become true friends for their masters and remain them throughout their lives. As the fourteenth breed bred in Italy, the Cane Corso is the pride and national treasure of this country. In the character of the dogs, the dedication of shepherds and the courage of fighting breeds are surprisingly intertwined, and also the lively temperament of the Italians themselves is reflected.\n\nCane Corso have sensitivity and intuition, they are ready to protect the owner and his family at any time and in any situation, which makes them unsurpassed guards. If you live in a dog of this breed, there is no need for alarm systems. They will not meet a thief who has penetrated the house with aggression, which is different from other guard dogs, but the robber will very much regret meeting the native of the sunny Apennines.The aggressive reaction of the Cane Corso is left as a last resort, when he feels that a real threat is hanging over the owner and his property.",

                   Breed = "Cane Corso",
                   Country = "Italy",
                   Weight = "♂ 45-50 kg, ♀ 40-45 kg",
                   Height = "♂ 64-68 cm, ♀ 60-64 cm",
                   LifeExpectancy = "9-11 Years",

                   Aggressiveness = 4,
                   Molting = 3,
                   Health = 4,
                   Intelligence = 4,
                   Activity = 4,
                   MaintenanceCost = 2,
                   Noise = 4,
                   Training = 4,
                   SecurityQualities = 5,
                   Price = "800-1000 $"
                },
                new DogInfo(){
                   DogTypeId = context.DogTypes.Where(x => x.Type == "Watchdog").FirstOrDefault().Id,

                   MainPhoto = path + "Mdoberman.jpg",
                   BigPhoto = path + "Bdoberman.jpg",

                   MainDescription = "The Doberman is a dog that most amazingly combines high intelligence and devotion, fearlessness and vigilance, strength and grace.",
                   BigDescription = "The Doberman is a breed that is confidently in the top 20 in popularity. To the question: \"What are these animals famous for?\" - experts will tell you about the legendary Trefa, a Doberman policeman who served in the St. Petersburg police at the beginning of the 20th century. With his help, more than 1,500 crimes were solved. Experts will also suggest reading Yesenin, who has the lines: \"Give me, Jim, luckily a paw for me.I have never seen such a paw before...\", and they will tell you that the favorite of the great Russian artist Vasily Kachalov was a Doberman. And how many more stories you will hear about this wonderful dog ...",

                   Breed = "Doberman",
                   Country = "Germany",
                   Weight = "♂ 40-45 kg, ♀ 32-35 kg",
                   Height = "♂ 68-72 cm, ♀ 63-68 cm",
                   LifeExpectancy = "10-14 Years",

                   Aggressiveness = 3,
                   Molting = 3,
                   Health = 4,
                   Intelligence = 4,
                   Activity = 5,
                   MaintenanceCost = 3,
                   Noise = 3,
                   Training = 5,
                   SecurityQualities = 5,
                   Price = "200-600 $"
                },
                new DogInfo(){
                   DogTypeId = context.DogTypes.Where(x => x.Type == "Watchdog").FirstOrDefault().Id,

                   MainPhoto = path + "Mwhiteswiisshepherd.jpg",
                   BigPhoto = path + "Bwhiteswiisshepherd.jpg",

                   MainDescription = "The White Swiss Shepherd Dog is the personification of beauty and friendliness. Gentle, attentive, understanding, with a wonderful disposition, she is an ideal companion and loyal friend.",
                   BigDescription = "Many dog ​​lovers have a white Swiss shepherd dog after being conquered by the spectacular, outstanding appearance of these animals. Only over time do they discover their excellent qualities inherent in serious service dogs. This beautiful, affectionate, good-natured dog with an impressive texture, unpretentious and hardy, easy-going and tireless in games. The love of white Swiss shepherd dogs for their owners is boundless, they need to know that close people are nearby, to feel family warmth and feel needed.",

                   Breed = "Swiss Shepherd",
                   Country = "Switzerland",
                   Weight = "♂ 30-40 kg, ♀ 25-35 kg",
                   Height = "♂ 58-66 cm, ♀ 53-61 cm",
                   LifeExpectancy = "13-15 Years",

                   Aggressiveness = 1,
                   Molting = 5,
                   Health = 4,
                   Intelligence = 4,
                   Activity = 4,
                   MaintenanceCost = 3,
                   Noise = 4,
                   Training = 5,
                   SecurityQualities = 5,
                   Price = "450-600 $"
                },
                new DogInfo(){
                   DogTypeId = context.DogTypes.Where(x => x.Type == "Watchdog").FirstOrDefault().Id,

                   MainPhoto = path + "Mgermandog.jpg",
                   BigPhoto = path + "Bgermandog.jpg",

                   MainDescription = "Great Dane is a real aristocrat of the canine world. He wins hearts with majestic beauty, intelligence, affectionate attitude towards households and excellent protective qualities.",
                   BigDescription = "The Great Dane at first meeting seems to be a formidable and even dangerous dog, thanks to its outstanding physical characteristics. However, behind the appearance of a harsh giant, in fact, lies a calm and incredibly loyal to the family kind-hearted man. He is not prone to aggression, unless the actions of an outsider provoke the dog to protect the life of the owners or his own.",
                   Breed = "Great Dane",
                   Country = "Germany",
                   Weight = "50-80 kg",
                   Height = "♂ 80-90 cm, ♀ 72-84 cm",
                   LifeExpectancy = "8-10 Years",

                   Aggressiveness = 2,
                   Molting = 3,
                   Health = 2,
                   Intelligence = 3,
                   Activity = 3,
                   MaintenanceCost = 5,
                   Noise = 3,
                   Training = 3,
                   SecurityQualities = 5,
                   Price = "700-1000$"
                },

                new DogInfo(){
                   DogTypeId = context.DogTypes.Where(x => x.Type == "Hunting").FirstOrDefault().Id,

                   MainPhoto = path + "Mbigle.jpg",
                   BigPhoto = path + "Bbigle.jpg",

                   MainDescription = "The Beagle belongs to the hound breeds of dogs. This cheerful good-natured person will become a great friend: loving, patient and, what is important, unpretentious in care.",
                   BigDescription = "Beagle instantly conquers with its remarkable charm. A dog's hazel eyes look straight into the soul, especially if the animal intends to beg a tidbit from you. The charming look of the fidget is in perfect harmony with his character, so do not expect meekness and calmness from the beagle. Despite the moderately short legs, the dog can reach high speed when chasing a pigeon or a neighbor's cat. Bigleys are by nature very active. There is no better entertainment for this breed than a walk in a city park. Bring a frisbee or a tennis ball with you - and there will be no limit to your dog's happiness.",

                   Breed = "Beagle",
                   Country = "UK",
                   Weight = "8-18 kg",
                   Height = "33-40 cm",
                   LifeExpectancy = "11-15 Years",

                   Aggressiveness = 2,
                   Molting = 3,
                   Health = 3,
                   Intelligence = 3,
                   Activity = 4,
                   MaintenanceCost = 3,
                   Noise = 3,
                   Training = 3,
                   SecurityQualities = 4,
                   Price = "650-800 $"
                },
                new DogInfo(){
                   DogTypeId = context.DogTypes.Where(x => x.Type == "Hunting").FirstOrDefault().Id,

                   MainPhoto = path + "Mdalmatian.jpg",
                   BigPhoto = path + "Bdalmatian.jpg",

                   MainDescription = "The Dalmatian is an energetic and cheerful pet. Thanks to its striking appearance, you will definitely not go unnoticed while walking in the park and on dog grounds.",
                   BigDescription = "The Dalmatian is one of the breeds for which the \"media\" and momentary popularity have brought more harm than good. Dogs with a difficult temperament and high needs for daily exercise do not get along with every fan of the Disney cartoon. But experienced and responsible owners will find a loyal friend and wonderful companion in this energetic creation.",

                   Breed = "Dalmatian",
                   Country = "Croatia",
                   Weight = "♂ 27-32 kg, ♀ 24-29 kg",
                   Height = "♂ 56-62 kg, ♀ 54-60 kg",
                   LifeExpectancy = "10-13 Years",

                   Aggressiveness = 1,
                   Molting = 4,
                   Health = 2,
                   Intelligence = 4,
                   Activity = 5,
                   MaintenanceCost = 4,
                   Noise = 2,
                   Training = 4,
                   SecurityQualities = 3,
                   Price = "250-500 $"
                },
                new DogInfo(){
                   DogTypeId = context.DogTypes.Where(x => x.Type == "Hunting").FirstOrDefault().Id,

                   MainPhoto = path + "Mkurzhaar.jpg",
                   BigPhoto = path + "Bkurzhaar.jpg",

                   MainDescription = "Kurzhaar is a clockwork toy that does not know rest. The energy of the dog is in full swing, involving it in adventures. This is a versatile hunting breed, whose skills are easy to find application.",
                   BigDescription = "Kurzhaar is the choice of activists who are crazy about jogging and walking in the company of a four-legged friend. The dog's playfulness and enthusiasm make it an excellent companion. The animal will find a common language both with an adult and with a child who needs an eye and an eye. Kurzhaar will not leave indifferent the hunter either: this breed is always in its element - on land and in water! The dog will not be frightened by either the mating season of the partridges or the strong antlers of the deer. However, the fearlessness of the shorthaired pointer will come to naught before the chance to while away the whole day alone. The regular absence of the owner of the house disposes the animal to a vivid protest. It manifests itself in damaged interior items and aggressive behavior of the dog.",
                   
                   Breed = "Kurzhaar",
                   Country = "Germany",
                   Weight = "♂ 25-32 kg, ♀ 20-27 kg",
                   Height = "♂ 62-66 kg, ♀ 58-63 kg",
                   LifeExpectancy = "12-14 Years",

                   Aggressiveness = 2,
                   Molting = 4,
                   Health = 2,
                   Intelligence = 5,
                   Activity = 5,
                   MaintenanceCost = 3,
                   Noise = 2,
                   Training = 5,
                   SecurityQualities = 4,
                   Price = "550-800 $"
                },
                new DogInfo(){
                   DogTypeId = context.DogTypes.Where(x => x.Type == "Hunting").FirstOrDefault().Id,

                   MainPhoto = path + "Mweimaraner.jpg",
                   BigPhoto = path + "Bweimaraner.jpg",

                   MainDescription = "The Weimaraner is a hound of aristocratic beauty and athletic build. The dog has universal hunting qualities and a good disposition, which has earned it the reputation of an excellent companion.",
                   BigDescription = "Weimaraner has great looks. This elegant dog with refined forms seemed to have jumped from the paintings of the Renaissance painters. Her impetuous appearance eloquently demonstrates that at any moment she is ready to rush over the horizon and return, holding her prey in her mouth. However, within the walls of his home, the Weimaraner easily forgets about his hunting purpose, transforming into an affectionate, gentle friend who loves his family and constantly strives to take a place at the feet of his adored owner.",

                   Breed = "Weimaraner",
                   Country = "Germany",
                   Weight = "♂ 25-32 cm, ♀ 23-29 cm",
                   Height = "♂ 59-70 kg, ♀ 57-65 kg",
                   LifeExpectancy = "10-13 Years",

                   Aggressiveness = 2,
                   Molting = 2,
                   Health = 2,
                   Intelligence = 5,
                   Activity = 5,
                   MaintenanceCost = 4,
                   Noise = 2,
                   Training = 5,
                   SecurityQualities = 3,
                   Price = "450-850 $"
                },
                new DogInfo(){
                   DogTypeId = context.DogTypes.Where(x => x.Type == "Hunting").FirstOrDefault().Id,

                   MainPhoto = path + "Mdwarfdachshund.jpg",
                   BigPhoto = path + "Bdwarfdachshund.jpg",

                   MainDescription = "The dwarf dachshund (miniature dachshund, mini-dachshund) is the closest relative of the standard dachshund, which has the same exterior, but is inferior in size. In terms of dimensions, the breed is an \"intermediate link\" between the standard and rabbit dachshunds.",
                   BigDescription = "The dwarf dachshund is a groovy \"sausage\", always ready to save this world and its own owner to boot. Do not flatter yourself with the toy dimensions of the corpulent short-legged and do not try to see a sofa sloth in it. A real mini-dachshund is an incredibly curious pet and a gambling burrowing inspector who is in a permanent search for suitable prey. At home, the dog is forced to reduce the degree of activity, so it takes out its hunting predilections on other small pets or toys.",

                   Breed = "Dwarf Dachshund",
                   Country = "Germany",
                   Weight = "4-5 kg",
                   Height = "about 30 cm",
                   LifeExpectancy = "12-15 Years",

                   Aggressiveness = 3,
                   Molting = 2,
                   Health = 3,
                   Intelligence = 4,
                   Activity = 3,
                   MaintenanceCost = 3,
                   Noise = 3,
                   Training = 2,
                   SecurityQualities = 2,
                   Price = "250-500 $"
                },
                new DogInfo(){
                   DogTypeId = context.DogTypes.Where(x => x.Type == "Hunting").FirstOrDefault().Id,

                   MainPhoto = path + "Mjackrussell.jpg",
                   BigPhoto = path + "Bjackrussell.jpg",

                   MainDescription = "The Jack Russell Terrier is a recognizable and popular dog breed. This is a pet that you will not be bored with for a minute.",
                   BigDescription = "The Jack Russell Terrier was previously famous for its working qualities as a burrowing dog, but few modern breeders systematically develop the hunting instincts inherent in the genes of these frisky babies. In the twentieth century, they turned into loyal and funny companions, real favorites of families who are used to spending their leisure time actively.",

                   Breed = "Jack Russell Terrier",
                   Country = "UK",
                   Weight = "5-7 kg",
                   Height = "25-30 cm",
                   LifeExpectancy = "13-16 Years",

                   Aggressiveness = 5,
                   Molting = 3,
                   Health = 3,
                   Intelligence = 4,
                   Activity = 5,
                   MaintenanceCost = 2,
                   Noise = 5,
                   Training = 4,
                   SecurityQualities = 5,
                   Price = "650-800 $"
                },

                new DogInfo(){
                   DogTypeId = context.DogTypes.Where(x => x.Type == "Smart").FirstOrDefault().Id,

                   MainPhoto = path + "Mbordercollie.jpg",
                   BigPhoto = path + "Bbordercollie.jpg",
                   
                   MainDescription = "The Border Collie is the smartest breed in the world, used as a companion or working dog. With a great desire, \"grazes\" all living things, even a person, if there are no sheep or cows nearby.",
                   BigDescription = "Border Collies are devoted clever people and incredible workaholics who openly despise a passive lifestyle and come to an indescribable delight from any activity associated with increased physical activity and energy consumption. The ancestors of modern boarders were excellent shepherds, so the passion for orderliness is in the blood of these shaggy \"managers\". If there is no flock of sheep nearby, the border collie will graze any other living creatures, and only an exciting game can distract him from this activity. Representatives of this breed are loyal friends, capable students and consummate intellectuals. However, in order for the animal to have the opportunity to reveal its potential, the owner will need maximum efforts: the border collie is not one of those dogs who are content with a soft bed and a mountain of food in a bowl.",

                   Breed = "Border Collie",
                   Country = "UK",
                   Weight = "15-20 kg",
                   Height = "♂ 50-53 cm, ♀ 47-52 cm",
                   LifeExpectancy = "12-15 Years",

                   Aggressiveness = 1,
                   Molting = 4,
                   Health = 4,
                   Intelligence = 5,
                   Activity = 5,
                   MaintenanceCost = 3,
                   Noise = 2,
                   Training = 5,
                   SecurityQualities = 5,
                   Price = "800-900 $"
                },
                new DogInfo(){
                   DogTypeId = context.DogTypes.Where(x => x.Type == "Smart").FirstOrDefault().Id,

                   MainPhoto = path + "Mpapillon.jpg",
                   BigPhoto = path + "Bpapillon.jpg",

                   MainDescription = "Papillon, also known as papillon, also known as continental toy spaniel, is an ornamental companion dog, whose business card is graceful ears decorated with long hair, reminiscent of the spread wings of a butterfly.",
                   BigDescription = "Papillons or daddies, as domestic breeders affectionately call their pets, are smart, high-spirited and sociable kids who will forgive their owner for everything, except for lack of attention to their own person. The life of these wonderful in every respect fluffy completely and completely revolves around the one whom they have chosen as their elder friend. Restless and unusually easy-going papillons are always ready to support any initiative of the owner, be it a banal game with a ball, a trip to the nearest supermarket or a long voyage across countries and continents.",

                   Breed = "Papillon",
                   Country = "France",
                   Weight = "3-5 kg",
                   Height = "20-28 cm",
                   LifeExpectancy = "13-15 Years",

                   Aggressiveness = 4,
                   Molting = 3,
                   Health = 4,
                   Intelligence = 5,
                   Activity = 4,
                   MaintenanceCost = 2,
                   Noise = 4,
                   Training = 4,
                   SecurityQualities = 5,
                   Price = "400-500 $"
                },
                new DogInfo(){
                   DogTypeId = context.DogTypes.Where(x => x.Type == "Smart").FirstOrDefault().Id,

                   MainPhoto = path + "Mpoodle.jpg",
                   BigPhoto = path + "Bpoodle.jpg",

                   MainDescription = "The Jack Russell Terrier is a recognizable and popular dog breed. This is a pet that you will not be bored with for a minute.",
                   BigDescription = "The poodle is the embodiment of beauty and extravagant decorativeness, combined with the harmonious constitution of this dog, its magnificent temperament, high intelligence. The adorable appearance of the poodle sparkles with artistry, charm and expression, and his kindness and love of life knows no bounds. These wonderful dogs have an incredible loyalty that extends to all family members, while poodles are very sensitive to human attention. They are funny, mischievous, like to fool around and are always ready to take part in games and fun.",

                   Breed = "Poodle",
                   Country = "France",
                   Weight = "♂ 8-14 kd ♀ 8-12 cm",
                   Height = "♂ 28-35 cm, ♀ 24-28 cm",
                   LifeExpectancy = "13-16 Years",

                   Aggressiveness = 2,
                   Molting = 1,
                   Health = 3,
                   Intelligence = 5,
                   Activity = 4,
                   MaintenanceCost = 4,
                   Noise = 3,
                   Training = 5,
                   SecurityQualities = 2,
                   Price = "600-900 $"
                },
                new DogInfo(){
                   DogTypeId = context.DogTypes.Where(x => x.Type == "Smart").FirstOrDefault().Id,

                   MainPhoto = path + "Msheltie.jpg",
                   BigPhoto = path + "Bsheltie.jpg",

                   MainDescription = "Sheltie (Shetland Sheepdog) - a native of northeastern Scotland; a cheerful companion, a responsible nanny and a devoted friend.",
                   BigDescription = "Sheltie is a loving fluffy with a conflict-free character, a charming smile and endless self-esteem, which you just want to embrace. From a real shepherd dog in today's Shelties, only a passion for walks and a ringing, barking bark remained, which, however, did not spoil them at all. Moreover, in just a few decades, these clever Shetlandic girls have managed to radically change their \"qualifications\", having passed the difficult path from humble rural shepherds to real townspeople.",

                   Breed = "Sheltie",
                   Country = "UK",
                   Weight = "6.8-11.3kg",
                   Height = "♂ 34-40 cm, ♀ 32-37 cm",
                   LifeExpectancy = "12-14 Years",

                   Aggressiveness = 1,
                   Molting = 5,
                   Health = 4,
                   Intelligence = 5,
                   Activity = 5,
                   MaintenanceCost = 2,
                   Noise = 2,
                   Training = 4,
                   SecurityQualities = 5,
                   Price = "300-450 $"
                },
                new DogInfo(){
                   DogTypeId = context.DogTypes.Where(x => x.Type == "Smart").FirstOrDefault().Id,

                   MainPhoto = path + "Maustralianshepherd.jpg",
                   BigPhoto = path + "Baustralianshepherd.jpg",

                   MainDescription = "The Australian Shepherd has amazing beauty. Her expressive gaze will drive even an avid cat lover crazy.",
                   BigDescription = "The Australian Shepherd is a harmonious combination of good looks and flexible intelligence. These dogs are known all over the world as reliable and loyal companions who will cheer you up with their funny antics. For Aussies, there is no better entertainment than an active walk with the owner in a city park. Animals truly enjoy the company of their family and do not like to be alone for a long time. This charming shagmatist will show you by his example what inexhaustible optimism and the ability to have fun all day long!",

                   Breed = "Australian Shepherd",
                   Country = "USA",
                   Weight = "♂ 25-30 kg, ♀ 18-25 kg",
                   Height = "♂ 34-40 cm, ♀ 32-37 cm",
                   LifeExpectancy = "13-15 Years",

                   Aggressiveness = 3,
                   Molting = 4,
                   Health = 4,
                   Intelligence = 5,
                   Activity = 4,
                   MaintenanceCost = 3,
                   Noise = 4,
                   Training = 4,
                   SecurityQualities = 4,
                   Price = "800-1100 $"
                },
                new DogInfo(){
                   DogTypeId = context.DogTypes.Where(x => x.Type == "Smart").FirstOrDefault().Id,

                   MainPhoto = path + "Mwelshcorgipembroke.jpg",
                   BigPhoto = path + "Bwelshcorgipembroke.jpg",

                   MainDescription = "The Welsh Corgi Pembroke is an amazing dog, a favorite breed of Her Majesty Queen Elizabeth II of Great Britain, a small shepherd dog with a big and fearless heart.",
                   BigDescription = "The Pembroke Welsh Corgi is a large dog in a small body. This characteristic is most often heard from the owners of these dogs. It's amazing how such a medium-sized animal contains so much love, cheerfulness, sociability and devotion to man. And in terms of intelligence and intuition, the corgi will give odds to many recognized human assistants from among large service dogs. Excellent character, amazing artistic abilities, charming appearance allowed the representatives of the breed to win love in many countries of the world. It is becoming more and more popular with us.",

                   Breed = "Welsh Corgi",
                   Country = "UK",
                   Weight = "9-13 kg",
                   Height = "25-30 cm",
                   LifeExpectancy = "9-12 Years",

                   Aggressiveness = 1,
                   Molting = 5,
                   Health = 3,
                   Intelligence = 5,
                   Activity = 4,
                   MaintenanceCost = 2,
                   Noise = 4,
                   Training = 5,
                   SecurityQualities = 5,
                   Price = "400-650 $"
                },

                new DogInfo(){
                   DogTypeId = context.DogTypes.Where(x => x.Type == "Kind").FirstOrDefault().Id,

                   MainPhoto = path + "Mernesemountaindog.jpg",
                   BigPhoto = path + "Bbernesemountaindog.jpg",

                   MainDescription = "The Bernese Mountain Dog (Bernese Shepherd Dog) is an affectionate and charming giant with the kindest \"smile\" in the world. Representatives of this breed are ideal companions with an innate sense of tact and an unusually peaceful disposition.",
                   BigDescription = "Bernese Mountain Dogs are good-natured dogs and faithful helpers. They get along excellently with every member of the family, and kids are condescendingly forgiving any leprosy. Patience and poise have made the Berns almost ideal pets. They are not capricious in learning and learn commands easily. In addition, they inherited excellent watchdog skills from their ancestors, which they gladly use whenever the opportunity arises.",

                   Breed = "Bernese Mountain",
                   Country = "Switzerland",
                   Weight = "♂ 39-50 kd ♀ 36-48 cm",
                   Height = "♂ 64-70 cm, ♀ 58-66 cm",
                   LifeExpectancy = "8-10 Years",

                   Aggressiveness = 2,
                   Molting = 5,
                   Health = 3,
                   Intelligence = 5,
                   Activity = 4,
                   MaintenanceCost = 4,
                   Noise = 3,
                   Training = 5,
                   SecurityQualities = 5,
                   Price = "1000-1600 $"
                },
                new DogInfo(){
                   DogTypeId = context.DogTypes.Where(x => x.Type == "Kind").FirstOrDefault().Id,

                   MainPhoto = path + "Mbostonterrier.jpg",
                   BigPhoto = path + "Bbostonterrier.jpg",

                   MainDescription = "The Boston Terrier is a small decorative breed of dog with a flattened muzzle, large eyes and a spotted coat, bred in the United States by crossing an English Bulldog with an English Terrier.",
                   BigDescription = "Boston Terriers are ultra-positive \"eyes\" who will be equally happy to walk with you in the shops and doze on the couch to the muttering of their favorite TV series. In cynological circles, \"Bostons\" are considered the most responsive and non-conflict pets, easy to contact, sometimes even to the detriment of their own safety. They never dictate their terms and do not arrange lawlessness within the framework of a single apartment. In addition, these smart-looking handsome people are great comedians who strive to fill the owner's life with bright and funny moments.",

                   Breed = "Boston Terrier",
                   Country = "USA",
                   Weight = "3-11 kg",
                   Height = "23-38 cm",
                   LifeExpectancy = "11-15 Years",

                   Aggressiveness = 3,
                   Molting = 2,
                   Health = 3,
                   Intelligence = 3,
                   Activity = 5,
                   MaintenanceCost = 3,
                   Noise = 3,
                   Training = 3,
                   SecurityQualities = 3,
                   Price = "550-700 $"
                },
                new DogInfo(){
                   DogTypeId = context.DogTypes.Where(x => x.Type == "Kind").FirstOrDefault().Id,

                   MainPhoto = path + "Mbulldog.jpg",
                   BigPhoto = path + "Bbulldog.jpg",

                   MainDescription = "The English Bulldog is a powerful, stocky dog ​​with well-developed muscles. For his imperturbable character, natural intelligence and cleanliness, the bulldog is called an \"English gentleman\".",
                   BigDescription = "English bulldog- not only an excellent bodyguard, but also a real friend. Even if for some reason you feel sad at heart, this stocky \"Englishman\" with a funny face will surely be able to cheer you up. But if a large head, a lot of wrinkles and folds on the face can cheer, then the abundant salivation inherent in dogs can push someone away. The English Bulldog has a very characteristic appearance that cannot be confused with any other. Because of his appearance, it may seem that the pet is by nature clumsy and slow. However, if there is a real danger for himself or the owner, then the dog will react quickly and be able to defend himself. The four-legged native of Foggy Albion has a calm disposition and a balanced character. These traits are combined with courage and even stubbornness.",

                   Breed = "English Bulldog",
                   Country = "UK",
                   Weight = "♂ 25-26 kd ♀ 22-23 cm",
                   Height = "about 40 cm",
                   LifeExpectancy = "7-10 Years",

                   Aggressiveness = 3,
                   Molting = 3,
                   Health = 3,
                   Intelligence = 3,
                   Activity = 2,
                   MaintenanceCost = 3,
                   Noise = 3,
                   Training = 3,
                   SecurityQualities = 5,
                   Price = "300-450 $"
                },
                new DogInfo(){
                   DogTypeId = context.DogTypes.Where(x => x.Type == "Kind").FirstOrDefault().Id,

                   MainPhoto = path + "Mpug.jpg",
                   BigPhoto = path + "Bpug.jpg",

                   MainDescription = "The pug is an ancient and consistently popular breed throughout its history. It is a wonderful companion dog for city dwellers.",
                   BigDescription = "The Pug is one of those breeds that, due to its characteristic appearance, is easily recognized even by those who do not consider themselves an expert in dog breeding. Of course, the modest size and special benevolence do not allow assigning the functions of a reliable guard to this pet, but as a loyal friend for the whole family and a source of positive emotions, the pug is ideal.",

                   Breed = "Pug",
                   Country = "Ancient China",
                   Weight = "6-8 kg",
                   Height = "28-32 cm",
                   LifeExpectancy = "13-14 Years",

                   Aggressiveness = 1,
                   Molting = 4,
                   Health = 1,
                   Intelligence = 3,
                   Activity = 3,
                   MaintenanceCost = 3,
                   Noise = 4,
                   Training = 2,
                   SecurityQualities = 4,
                   Price = "100-450 $"
                },
                new DogInfo(){
                   DogTypeId = context.DogTypes.Where(x => x.Type == "Kind").FirstOrDefault().Id,

                   MainPhoto = path + "Mserbernar.jpg",
                   BigPhoto = path + "Bserbernar.jpg",

                   MainDescription = "St. Bernard is a charming giant with a peaceful character and a slightly sad look. It is considered a typical family dog, but with the right training course it can become an excellent rescuer or watchman. Calm, disciplined, sincerely loves children.",
                   BigDescription = "The St. Bernards are natives of the Swiss Alps, selfless rescuers of travelers lost in the mountains, known for their phenomenal devotion to man. Serious and collected, these white-red giants are completely devoid of arrogance and desire to \"show off\" in front of their relatives. And what's the point of proving something to someone with such impressive dimensions. The St. Bernards feel most comfortable in large friendly families, where they are definitely not threatened with loneliness and lack of communication.",

                   Breed = "St. Bernard",
                   Country = "Switzerland",
                   Weight = "not less than 70 kg",
                   Height = "♂ 70-90 cm, ♀ 65-80 cm",
                   LifeExpectancy = "9-11 Years",

                   Aggressiveness = 1,
                   Molting = 4,
                   Health = 2,
                   Intelligence = 4,
                   Activity = 2,
                   MaintenanceCost = 5,
                   Noise = 3,
                   Training = 2,
                   SecurityQualities = 5,
                   Price = "300-450 $"
                },
                new DogInfo(){
                   DogTypeId = context.DogTypes.Where(x => x.Type == "Kind").FirstOrDefault().Id,

                   MainPhoto = path + "Mlabrador.jpg",
                   BigPhoto = path + "Blabrador.jpg",

                   MainDescription = "The Labrador is one of the most popular breeds in the world today. It is an ideal pet for families with children, hunters, rescuers and people with disabilities.",
                   BigDescription = "The Labrador is so widespread due to the surprisingly successful combination of external data and \"working\" qualities, which allow the breed to be not only companions in everyday life, but also serve for the good of man. They regularly rank at the top of the “most loyal”, “most obedient”, “most hardworking” dog ratings by professional breeders and ordinary owners.",

                   Breed = "Labrador Retriever",
                   Country = "Canada",
                   Weight = "♂ 27-34 kg ♀ 25-32 kg",
                   Height = "♂ 56-61 cm, ♀ 53-58 cm",
                   LifeExpectancy = "12-13 Years",

                   Aggressiveness = 1,
                   Molting = 4,
                   Health = 3,
                   Intelligence = 5,
                   Activity = 5,
                   MaintenanceCost = 4,
                   Noise = 1,
                   Training = 5,
                   SecurityQualities = 2,
                   Price = "200-400 $"
                },

                new DogInfo(){
                   DogTypeId = context.DogTypes.Where(x => x.Type == "Expensive").FirstOrDefault().Id,

                   MainPhoto = path + "MalaskanKleeKai.jpg",
                   BigPhoto = path + "BalaskanKleeKai.jpg",

                   MainDescription = "Alaskan Klee-Kai is a miniature copy of a husky and a happy owner of a remarkable charm that will melt your heart! You cannot help smiling at such a charismatic pet.",
                   BigDescription = "The Alaskan Kli Kai is unique in every way. First, it can be considered an ideal alternative to its larger brethren, the Siberian Husky . This compact dog is perfect for keeping in an apartment. Secondly, the representatives of the breed are distinguished by their docile nature, which allows them to get along with any four-legged \"team\". Alaskan Kli-Kai is a miniature gentleman who will bring only positive emotions into the life of his master. The distant resemblance to a tame wolf cub gives it a special flavor that will appeal to even the most discerning dog breeder.",

                   Breed = "Alaskan Klee-Kai",
                   Country = "USA",
                   Weight = "♂ 10 kg ♀ 7 kg",
                   Height = "♂ 40 cm ♀ 34 cm",
                   LifeExpectancy = "13-14 Years",

                   Aggressiveness = 3,
                   Molting = 4,
                   Health = 3,
                   Intelligence = 5,
                   Activity = 4,
                   MaintenanceCost = 2,
                   Noise = 4,
                   Training = 4,
                   SecurityQualities = 1,
                   Price = "more than 4500 $"
                },
                new DogInfo(){
                   DogTypeId = context.DogTypes.Where(x => x.Type == "Expensive").FirstOrDefault().Id,

                   MainPhoto = path + "Mcanarydog.jpg",
                   BigPhoto = path + "Bcanarydog.jpg",

                   MainDescription = "The Canary Dog is a breed of molossoid dogs with heightened territorial and watchdog instincts, which originated on the islands of the Canary archipelago.",
                   BigDescription = "The Canary Dog is a balanced, albeit slightly suspicious brutal, who considers it his mission to protect the peace of the family in which he lives. Restrained enough not to rush at everyone he meets, but also not phlegmatic, this Molossian guard is always ready for a feat in the name of the master. In her free time from guard activities, Presa Canario is not averse to throwing off the burden of worries and playing with the household. Just do not try to educate him as a babysitter or a deliveryman of morning newspapers - in these niches the Canary dogs are full of more successful competitors.",

                   Breed = "Dogo Canary",
                   Country = "Spain",
                   Weight = "♂ 50 kg ♀ 40 kg",
                   Height = "♂ 60-65 cm ♀ 56-61 cm",
                   LifeExpectancy = "9-11 Years",

                   Aggressiveness = 3,
                   Molting = 2,
                   Health = 2,
                   Intelligence = 3,
                   Activity = 3,
                   MaintenanceCost = 3,
                   Noise = 2,
                   Training = 2,
                   SecurityQualities = 5,
                   Price = "2000-4000 $"
                },
                new DogInfo(){
                   DogTypeId = context.DogTypes.Where(x => x.Type == "Expensive").FirstOrDefault().Id,

                   MainPhoto = path + "Mtibetanmastiff.jpg",
                   BigPhoto = path + "Btibetanmastiff.jpg",

                   MainDescription = "The Tibetan Mastiff is a huge handsome man, which is notable for its powerful dimensions. However, his outward resemblance to the king of beasts does not in the least detract from his good nature.",
                   BigDescription = "The Tibetan Mastiff is rightfully considered the property of a mysterious corner of the globe - the \"roof of the world\" called Tibet. Representatives of this breed are reputed to be reliable and fearless defenders who are not devoid of self-esteem and independent character. Looking at the threatening appearance of the dog, it is difficult to imagine that this breed is one of the most friendly and loyal. The centuries-old duet of man and mastiff taught the latter to show remarkable patience and understanding.",

                   Breed = "Tibetan Mastiff",
                   Country = "Tibet",
                   Weight = "64-78 kg",
                   Height = "from 65",
                   LifeExpectancy = "10-11 Years",

                   Aggressiveness = 4,
                   Molting = 3,
                   Health = 3,
                   Intelligence = 3,
                   Activity = 3,
                   MaintenanceCost = 5,
                   Noise = 2,
                   Training = 3,
                   SecurityQualities = 5,
                   Price = "more than 2200 $"
                },
                new DogInfo(){
                   DogTypeId = context.DogTypes.Where(x => x.Type == "Expensive").FirstOrDefault().Id,

                   MainPhoto = path + "Msamoyeddog.jpg",
                   BigPhoto = path + "Bsamoyeddog.jpg",

                   MainDescription = "The Samoyed is a friendly, loyal animal that combines the best traits of an active leisure companion and a playful pet.",
                   BigDescription = "The Samoyed dog not only has a magnificent appearance, but also has an enviable intellect, an excellent docile character, and dedication. In conditions of high latitudes, it has faithfully served people for many centuries. The harsh conditions of the north place special demands on a dog living next to a person. Protecting reindeer herds, hunting wild animals, working in a team, and practically any kind of activity in the Arctic, it is impossible to imagine without the participation of trained huskies. These animals are highly valued in the conditions of the \"civilized\" world.",

                   Breed = "Samoyed dog",
                   Country = "Siberia ",
                   Weight = "15-30 kg",
                   Height = "50-55 cm",
                   LifeExpectancy = "12-15 Years",

                   Aggressiveness = 1,
                   Molting = 4,
                   Health = 3,
                   Intelligence = 3,
                   Activity = 4,
                   MaintenanceCost = 3,
                   Noise = 5,
                   Training = 3,
                   SecurityQualities = 2,
                   Price = "1500-2000 $"
                },
                new DogInfo(){
                   DogTypeId = context.DogTypes.Where(x => x.Type == "Expensive").FirstOrDefault().Id,

                   MainPhoto = path + "Mcavalierkingcharlesspaniel.jpg",
                   BigPhoto = path + "Bcavalierkingcharlesspaniel.jpg",

                   MainDescription = "The Cavalier King Charles Spaniel is a cheerful shaggy fidget with an expressive, flirtatious appearance and a good-natured character. It will revive any home with its own presence and will perfectly cope with the role of a reliable companion.",
                   BigDescription = "The Cavalier King Charles Spaniel is an affable clever girl with a heartfelt look and long satin fur, ready to \"drown\" anyone who comes into view in the sea of ​​her own charm. These energetic, sociable sympathizers make exceptional friends. Cheer up, make laugh, relieve stress - all this dogs are ready to do for the owner every day in exchange only for a kind word and affection. It is not for nothing that in the homeland of the breed, in England, the Cavalier Kings have long established a reputation as professional comforters.",

                   Breed = "Cavalier K Spaniel",
                   Country = "UK",
                   Weight = "5.5 to 8 kg",
                   Height = "up to 32 cm",
                   LifeExpectancy = "11-12 Years",

                   Aggressiveness = 1,
                   Molting = 3,
                   Health = 3,
                   Intelligence = 4,
                   Activity = 4,
                   MaintenanceCost = 3,
                   Noise = 2,
                   Training = 4,
                   SecurityQualities = 1,
                   Price = "900-2000 $"
                },
                new DogInfo(){
                   DogTypeId = context.DogTypes.Where(x => x.Type == "Expensive").FirstOrDefault().Id,

                   MainPhoto = path + "Mshibainu.jpg",
                   BigPhoto = path + "Bshibainu.jpg",

                   MainDescription = "The Shiba Inu is an adorable dog with plush hair and a wayward temperament. Being the owner of such a pet is not easy, but if you gain his respect and trust, you will get a lot of pleasure from communicating with an intelligent and inquisitive friend.",
                   BigDescription = "The Shiba Inu is a hunting dog bred in Japan. Its history is about two and a half thousand years old. Modern representatives of the breed often act as companions. An inquisitive and friendly disposition allows them to get along well with the owner, but the animals are capricious and require competent training. Since 1936, Shiba Inu has been recognized as the property of Japan. Integral character, high intellectual level and special fortitude made these animals popular among dog breeders. Being the owner of such a pet is not easy, but if you gain his respect and trust, you will get a lot of pleasure from communicating with an intelligent and inquisitive friend. The breed is suitable for experienced dog handlers, but as the first dog, the Shiba Inu with its complex disposition is not the best option.",

                   Breed = "Shiba Inu",
                   Country = "Japan",
                   Weight = "♂ 9-14 kg ♀ 8-13 kg",
                   Height = "♂ 40 cm ♀ 37 cm",
                   LifeExpectancy = "12-15 Years",

                   Aggressiveness = 3,
                   Molting = 5,
                   Health = 3,
                   Intelligence = 3,
                   Activity = 4,
                   MaintenanceCost = 3,
                   Noise = 2,
                   Training = 2,
                   SecurityQualities = 3,
                   Price = "2000-3000 $"
                }
            };            
            await context.Set<DogInfo>().AddRangeAsync(dogs);
        }
    }
}
