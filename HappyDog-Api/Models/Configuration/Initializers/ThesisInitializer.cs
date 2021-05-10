using HappyDog_Api.Models.Configuration.Interfaces;
using HappyDog_Api.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HappyDog_Api.Models.Configuration.Initializers
{
    public class ThesisInitializer : ITypeInitializer
    {
        public async Task Init(ApplicationContext context)
        {
            Thesis[] thesis = new Thesis[] {
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Shiba Inu").FirstOrDefault().Id,
                    Info = "Avarege price of Shiba Inu = " + context.DogInfos.Where(x=> x.Breed == "Shiba Inu").FirstOrDefault().Price,
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Shiba Inu").FirstOrDefault().Id,
                    Info = "Animals of this breed are distinguished by high intelligence and strong character."
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Shiba Inu").FirstOrDefault().Id,
                    Info="Shiba Inu are terrible owners, they categorically do not like to share."},
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Shiba Inu").FirstOrDefault().Id,
                    Info = "Dogs are very clean, deliberately avoid dirt, lick themselves thoroughly."
                },

                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Rottweiler").FirstOrDefault().Id,
                    Info = "Avarege price of Rottweiler = " + context.DogInfos.Where(x=> x.Breed == "Rottweiler").FirstOrDefault().Price,
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Rottweiler").FirstOrDefault().Id,
                    Info = "They need a serious and strong mentor. They will create a lot of problems for inexperienced owners who do not have the skills to work with service dogs."
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Rottweiler").FirstOrDefault().Id,
                    Info = "Rottweilers do not tolerate high temperatures, but in the cold they feel quite comfortable, thanks to the dense undercoat."
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Rottweiler").FirstOrDefault().Id,
                    Info = "Small dogs and puppies are treated indifferently and contemptuously. In large individuals, they feel rivals, often provoking them to fight."
                },

                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "German Shepherd").FirstOrDefault().Id,
                    Info = "Avarege price of German Shepherd = " + context.DogInfos.Where(x=> x.Breed == "German Shepherd").FirstOrDefault().Price,
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "German Shepherd").FirstOrDefault().Id,
                    Info = "German Shepherds can be used as guard dogs or search dogs, as well as companions for families."
                 }, 
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "German Shepherd").FirstOrDefault().Id,
                    Info = "German Shepherds are among the three smartest dog breeds (along with border collies and poodles)."
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "German Shepherd").FirstOrDefault().Id,
                   Info = "The average life span of a German shepherd is 9-13 years, after 7 years, strict health monitoring is required."
                },

                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Cane Corso").FirstOrDefault().Id,
                    Info = "Avarege price of Cane Corso = " + context.DogInfos.Where(x=> x.Breed == "Cane Corso").FirstOrDefault().Price,
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Cane Corso").FirstOrDefault().Id,
                    Info = "This dog has excellent guarding qualities. The territory in which the owner and members of his family live is considered his own space and is guarded with special care."
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Cane Corso").FirstOrDefault().Id,
                    Info = "Representatives of the breed are strong and hardy, differ in intelligence and ingenuity, in need of constant physical and mental activity."
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Cane Corso").FirstOrDefault().Id,
                    Info = "Cane Corso can be aggressive towards other dogs and animals, and to keep such emotions in check, puppies must be socialized from an early age."
                },

                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Doberman").FirstOrDefault().Id,
                    Info = "Avarege price of Doberman = " + context.DogInfos.Where(x=> x.Breed == "Doberman").FirstOrDefault().Price,
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Doberman").FirstOrDefault().Id,
                    Info = "It's hard to find a more versatile dog than the Doberman. This is a protector, and a companion, and a faithful companion, and just a family favorite. These animals are confidently included in the top lists of the most popular breeds in many countries of the world."
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Doberman").FirstOrDefault().Id,
                    Info = "The Doberman is endlessly loyal to his master and his family, he is quite friendly towards familiar people and pets. For all his temperament, he does not lose vigilance for a second and is always ready to help."
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Doberman").FirstOrDefault().Id,
                    Info = "This dog instinctively feels \"what is good and what is bad\", whether it concerns a person or a specific situation."
                },

                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Swiss Shepherd").FirstOrDefault().Id,
                    Info = "Avarege price of Swiss Shepherd = " + context.DogInfos.Where(x=> x.Breed == "Swiss Shepherd").FirstOrDefault().Price,
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Swiss Shepherd").FirstOrDefault().Id,
                    Info = "The White Swiss Shepherd Dog is a strong, temperamental, hardy, very energetic dog with a strong nervous system."
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Swiss Shepherd").FirstOrDefault().Id,
                    Info = "Outwardly, with the exception of color, it is similar to a German shepherd dog, but, unlike the one that is less reckless, excitable, demonstrates aggression only in case of an obvious threat."
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Swiss Shepherd").FirstOrDefault().Id,
                    Info = "The best place to live for the White Swiss Shepherd is a country house, but its unassuming character and ability to adapt to any conditions allow it to be kept in an urban environment."
                },

                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Great Dane").FirstOrDefault().Id,
                    Info = "Avarege price of Great Dane = " + context.DogInfos.Where(x=> x.Breed == "Great Dane").FirstOrDefault().Price,
                }, 
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Great Dane").FirstOrDefault().Id,
                    Info = "In popular culture, Great Danes are best known for the images of the animated Scooby Doo and the comic book hero Marmaduke, but real dogs do not at all look like the cowardly, stupid animals that are a constant source of trouble for owners."
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Great Dane").FirstOrDefault().Id,
                    Info = "A dog named Zeus is included in the Guinness Book of Records as the tallest dog in the world, his height at the withers was 111.8 cm.However, another dog from America, Giant George, surpassed him in total dimensions - with a height of 109.2 cm, the giant weighed 111 kg."
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Great Dane").FirstOrDefault().Id,
                    Info = "For the life of such a pet, a spacious house is needed, because it can hardly fit in an apartment, and constant presence in the yard is impossible due to short hair."
                },

                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Beagle").FirstOrDefault().Id,
                    Info = "Representatives of the breed are endowed with quick-wittedness and flexible intelligence - and all this is combined with stubbornness."
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Beagle").FirstOrDefault().Id,
                    Info = "The main problem of beagles is their loud barking, so be prepared for possible quarrels with your neighbors."
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Beagle").FirstOrDefault().Id,
                    Info = "It is not recommended to keep the beagle in the same apartment with cats or small decorative animals."
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Beagle").FirstOrDefault().Id,
                    Info = "Avarege price of Beagle = " + context.DogInfos.Where(x=> x.Breed == "Beagle").FirstOrDefault().Price,
                },

                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Dalmatian").FirstOrDefault().Id,
                    Info = "Avarege price of Dalmatian = " + context.DogInfos.Where(x=> x.Breed == "Dalmatian").FirstOrDefault().Price,
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Dalmatian").FirstOrDefault().Id,
                    Info = "About 12% of puppies are born deaf."
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Dalmatian").FirstOrDefault().Id,
                    Info = "These are rather large and very active animals, therefore it is preferable to be kept in a private house with the possibility of free range in a fenced area."
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Dalmatian").FirstOrDefault().Id,
                    Info = "Dalmatians are not suitable for homebodies and families with small children."
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Dalmatian").FirstOrDefault().Id,
                    Info = "Only dogs with black or brown spots on a white background are allowed to participate in exhibitions, but there are other color options."
                },

                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Kurzhaar").FirstOrDefault().Id,
                    Info = "Avarege price of Kurzhaar = " + context.DogInfos.Where(x=> x.Breed == "Kurzhaar").FirstOrDefault().Price,
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Kurzhaar").FirstOrDefault().Id,
                    Info = "Kurzhaar is a real clot of energy on four legs! Its minimum requirement is an hour of active physical exercise, and this is far from the limit."
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Kurzhaar").FirstOrDefault().Id,
                    Info = "Animals can catch game in any conditions, therefore they become indispensable companions of adherents of hunting."
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Kurzhaar").FirstOrDefault().Id,
                    Info = "Representatives of the breed cannot stand loneliness. Regular absence of the owner can provoke mental health problems in the dog."
                },

                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Weimaraner").FirstOrDefault().Id,
                    Info = "Avarege price of Weimaraner = " + context.DogInfos.Where(x=> x.Breed == "Weimaraner").FirstOrDefault().Price,
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Weimaraner").FirstOrDefault().Id,
                    Info = "Weimaraners are hardy, reckless, have a great flair. Dogs are able to take an active part in all types of hunting."
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Weimaraner").FirstOrDefault().Id,
                    Info = "Among other European hounds, they stand out for their original silver-gray color and distinctive eye color."
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Weimaraner").FirstOrDefault().Id,
                    Info = "They are gentle and affectionate with all family members, including children, but they choose the owner for themselves, to whom they are very attached."
                },

                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Dwarf Dachshund").FirstOrDefault().Id,
                    Info = "Avarege price of Dwarf Dachshund = " + context.DogInfos.Where(x=> x.Breed == "Dwarf Dachshund").FirstOrDefault().Price,
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Dwarf Dachshund").FirstOrDefault().Id,
                    Info = "In the body of a mini-dachshund, there is a creature with a strong character and self-esteem, who is not averse to taking the place of the leader in your family."
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Dwarf Dachshund").FirstOrDefault().Id,
                    Info = "Small animals for a miniature dachshund are potential prey, but it is quite possible to teach a dog not to torture a cat and other representatives of domestic fauna."
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Dwarf Dachshund").FirstOrDefault().Id,
                    Info = "The weak point of the breed is the spine, so any jumps are strictly contraindicated for dogs, and in the junior age - independent descents and ascents of stairs, as well as lifting by the scruff of the neck."
                },

                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Jack Russell Terrier").FirstOrDefault().Id,
                    Info = "Avarege price of Jack Russell Terrier = " + context.DogInfos.Where(x=> x.Breed == "Jack Russell Terrier").FirstOrDefault().Price,
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Jack Russell Terrier").FirstOrDefault().Id,
                    Info = "Jack Russell Terrier is suitable only for people who lead an active lifestyle and can provide the pet with regular physical activity."
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Jack Russell Terrier").FirstOrDefault().Id,
                    Info = "Contrary to the image replicated in the cinema, the Jack Russell Terrier is not always sweet and agreeable, he needs an experienced owner who is ready to devote a lot of time to education."
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Jack Russell Terrier").FirstOrDefault().Id,
                    Info = "The loud and loud barking, which was necessary on the hunt, can lead to conflicts with neighbors in a city apartment."
                },

                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Border Collie").FirstOrDefault().Id,
                    Info = "Avarege price of Border Collie = " + context.DogInfos.Where(x=> x.Breed == "Border Collie").FirstOrDefault().Price,
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Border Collie").FirstOrDefault().Id,
                    Info = "According to research results of the University of British Columbia, they are recognized as the smartest dog breed."
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Border Collie").FirstOrDefault().Id,
                    Info = "Border Collies love to graze everyone and everything, from poultry to humans."
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Border Collie").FirstOrDefault().Id,
                    Info = "Border Collies are not born companions, but they are quite capable of becoming one after a full course of training."
                },

                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Papillon").FirstOrDefault().Id,
                    Info = "Avarege price of Papillon = " + context.DogInfos.Where(x=> x.Breed == "Papillon").FirstOrDefault().Price,
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Papillon").FirstOrDefault().Id,
                    Info = "Representatives of this breed have irrepressible energy, therefore, they require systematic and prolonged walking."
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Papillon").FirstOrDefault().Id,
                    Info = "Continental Toy Spaniels are great intellectuals, endowed with everyday ingenuity and ingenuity. Papillon is ranked 8th on Stanley Coren's list of the smartest dog breeds."
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Papillon").FirstOrDefault().Id,
                    Info = "Individuals, the favorable period for whose socialization was missed, can show aggression towards other, weaker animals, and also bite."
                },

                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Poodle").FirstOrDefault().Id,
                    Info = "Avarege price of Poodle = " + context.DogInfos.Where(x=> x.Breed == "Poodle").FirstOrDefault().Price,
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Poodle").FirstOrDefault().Id,
                    Info = "Possesses an extraordinary mind, an outstanding sense of smell, hearing and sight. Large and small dogs can be used for hunting, detective service, truffle hunting."
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Poodle").FirstOrDefault().Id,
                    Info = "All poodles, even their smallest varieties, are unpretentious, have good health and have the status of long-livers."
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Poodle").FirstOrDefault().Id,
                    Info = "Dogs are absolutely not aggressive, on the contrary, they are endowed with special benevolence towards people."
                },

                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Sheltie").FirstOrDefault().Id,
                    Info = "Avarege price of Sheltie = " + context.DogInfos.Where(x=> x.Breed == "Sheltie").FirstOrDefault().Price,
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Sheltie").FirstOrDefault().Id,
                    Info = "Representatives of this breed are very similar to collies, although they are almost half their size."
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Sheltie").FirstOrDefault().Id,
                    Info = "All Shelties are extremely curious, so they will not miss the opportunity to get to know any representative of the fauna that they meet on their way."
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Sheltie").FirstOrDefault().Id,
                    Info = "Adults have an inexhaustible supply of energy and need good walking and regular physical activity."
                },

                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Australian Shepherd").FirstOrDefault().Id,
                    Info = "Avarege price of Australian Shepherd = " + context.DogInfos.Where(x=> x.Breed == "Australian Shepherd").FirstOrDefault().Price,
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Australian Shepherd").FirstOrDefault().Id,
                    Info = "Aussies are known for their friendliness, which allows them to easily get along with other animals."
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Australian Shepherd").FirstOrDefault().Id,
                    Info = "The good-natured appearance of the shepherd dogs does not diminish their ability to give a worthy rebuff to the offender."
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Australian Shepherd").FirstOrDefault().Id,
                    Info = "These animals are hyperresponsible and can look after a child, cat or hamster for several hours."
                },

                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Welsh Corgi").FirstOrDefault().Id,
                    Info = "Avarege price of Welsh Corgi = " + context.DogInfos.Where(x=> x.Breed == "Welsh Corgi").FirstOrDefault().Price,
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Welsh Corgi").FirstOrDefault().Id,
                    Info = "The Pembroke is a breed of dog that is in dire need of human society. Keeping her on the street, let alone on a leash, is absolutely unacceptable."
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Welsh Corgi").FirstOrDefault().Id,
                    Info = "The corgi's love for children has already become a legend. Absolutely without any fear, you can leave even a baby with him - the Pembroke will stoically endure all his pranks."
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Welsh Corgi").FirstOrDefault().Id,
                    Info = "Corgi is a dog ideal for a large and friendly family. Feels great both in a city apartment and in suburban housing."
                },

                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Bernese Mountain").FirstOrDefault().Id,
                    Info = "Avarege price of Bernese Mountain = " + context.DogInfos.Where(x=> x.Breed == "Bernese Mountain").FirstOrDefault().Price,
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Bernese Mountain").FirstOrDefault().Id,
                    Info = "They get along without problems with other pets, and with cats they are able to maintain a truly friendly relationship."
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Bernese Mountain").FirstOrDefault().Id,
                    Info = "Bernese Mountain Dogs graciously accept the master's attention, but begging for affection is not in their rules."
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Bernese Mountain").FirstOrDefault().Id,
                    Info = "They learn quickly and willingly fulfill commands, although they are somewhat inferior in intelligence and discipline to other shepherd dogs."
                },

                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Boston Terrier").FirstOrDefault().Id,
                    Info = "Avarege price of Boston Terrier = " + context.DogInfos.Where(x=> x.Breed == "Boston Terrier").FirstOrDefault().Price,
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Boston Terrier").FirstOrDefault().Id,
                    Info = "Most of the official duties of Boston Terriers are alien, but they have a territorial instinct, so in case of urgent need the dog can be entrusted with the protection of the apartment."
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Boston Terrier").FirstOrDefault().Id,
                    Info = "Unlike other brachycephalic dogs, \"Bostons\" do not suffer from excessive salivation, and their muzzles always remain dry and tidy."
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Boston Terrier").FirstOrDefault().Id,
                    Info = "Representatives of this breed are affable, friendly and malleable creatures, therefore they are often recommended to inexperienced owners, families with children, and also the elderly."
                },

                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "English Bulldog").FirstOrDefault().Id,
                    Info = "Avarege price of English Bulldog = " + context.DogInfos.Where(x=> x.Breed == "English Bulldog").FirstOrDefault().Price,
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "English Bulldog").FirstOrDefault().Id,
                    Info = "An adult English Bulldog is a rather lazy dog ​​and goes for a walk without much enthusiasm, maybe even stubborn. However, to keep in shape, daily walking is essential."
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "English Bulldog").FirstOrDefault().Id,
                    Info = "Four-legged gentlemen often make a lot of noise. They gurgle, wheeze, and snore at night."
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "English Bulldog").FirstOrDefault().Id,
                    Info = "Due to the large head and structural features of the skull, English Bulldogs have difficulties in reproducing offspring. Most puppies are born by caesarean section."
                },

                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Pug").FirstOrDefault().Id,
                    Info = "Avarege price of Pug = " + context.DogInfos.Where(x=> x.Breed == "Pug").FirstOrDefault().Price,
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Pug").FirstOrDefault().Id,
                    Info = "Pugs are friendly towards family members, strangers and other animals."
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Pug").FirstOrDefault().Id,
                    Info = "Due to the nature of the physiology, it is vitally important to monitor the temperature regime of the pug."
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Pug").FirstOrDefault().Id,
                    Info = "Pugs are not a rare dog, which means that you can buy a puppy in almost any city."
                },

                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "St. Bernard").FirstOrDefault().Id,
                    Info = "Avarege price of St. Bernard = " + context.DogInfos.Where(x=> x.Breed == "St. Bernard").FirstOrDefault().Price,
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "St. Bernard").FirstOrDefault().Id,
                    Info = "Balanced and good-natured by nature, St. Bernards easily get along with any pets, from cats to feathered pets."
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "St. Bernard").FirstOrDefault().Id,
                    Info = "Rescue dogs love companionship, but they also cope well with temporary loneliness, unless it spills over into permanent loneliness."
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "St. Bernard").FirstOrDefault().Id,
                    Info = "Adults are moderately playful and love long walks. But intense cardio loads only harm the representatives of this breed."
                },

                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Labrador Retriever").FirstOrDefault().Id,
                    Info = "Avarege price of Labrador Retriever = " + context.DogInfos.Where(x=> x.Breed == "Labrador Retriever").FirstOrDefault().Price,
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Labrador Retriever").FirstOrDefault().Id,
                    Info = "It has its pedigree from Canada, but the main merit in the creation of the breed belongs to English enthusiasts."
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Labrador Retriever").FirstOrDefault().Id,
                    Info = "A Labrador retriever can be kept in an apartment, but long daily walks and sufficient physical activity are required."
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Labrador Retriever").FirstOrDefault().Id,
                    Info = "The dog was created to be accompanied on a hunt, therefore it does not have good guarding qualities, but it gets along well with children and animals."
                },

                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Alaskan Klee-Kai").FirstOrDefault().Id,
                    Info = "Avarege price of Alaskan Klee-Kai = " + context.DogInfos.Where(x=> x.Breed == "Alaskan Klee-Kai").FirstOrDefault().Price,
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Alaskan Klee-Kai").FirstOrDefault().Id,
                    Info = "The Alaskan Klee Kai is a relatively young breed that is renowned for its friendly character with a piquant touch of stubbornness."
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Alaskan Klee-Kai").FirstOrDefault().Id,
                    Info = "Kli-kai love to frolic in the fresh air, so the choice between sleeping on the couch and walking in the city park is obvious."
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Alaskan Klee-Kai").FirstOrDefault().Id,
                    Info = "Representatives of the breed get along well with other pets and easily find a common language with children."
                },

                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Dogo Canary").FirstOrDefault().Id,
                    Info = "Avarege price of Dogo Canary = " + context.DogInfos.Where(x=> x.Breed == "Dogo Canary").FirstOrDefault().Price,
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Dogo Canary").FirstOrDefault().Id,
                    Info = "The breed is listed as potentially dangerous in a number of countries and is banned from import to Australia, Malaysia and New Zealand."
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Dogo Canary").FirstOrDefault().Id,
                    Info = "Presa Canario is a dog of one owner, so even living in a large family, the animal will obey the requirements of one."
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Dogo Canary").FirstOrDefault().Id,
                    Info = "Great Danes practically do not initiate fights with fellow tribesmen, but willingly participate in them."
                },

                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Tibetan Mastiff").FirstOrDefault().Id,
                    Info = "Avarege price of Tibetan Mastiff = " + context.DogInfos.Where(x=> x.Breed == "Tibetan Mastiff").FirstOrDefault().Price,
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Tibetan Mastiff").FirstOrDefault().Id,
                    Info = "This breed is not recommended for novice dog breeders: it requires competent socialization and incredible patience."
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Tibetan Mastiff").FirstOrDefault().Id,
                    Info = "The impressive size of the Tibetan is not always combined with the usual apartment, so it is best to keep the dog in a private house."
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Tibetan Mastiff").FirstOrDefault().Id,
                    Info = "The peak of activity of mastiffs occurs in the evening or even at night: it is then that it is best to walk with your pet on the street."
                },

                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Samoyed dog").FirstOrDefault().Id,
                    Info = "Avarege price of Samoyed dog = " + context.DogInfos.Where(x=> x.Breed == "Samoyed dog").FirstOrDefault().Price,
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Samoyed dog").FirstOrDefault().Id,
                    Info = "Samoyed is a primitive breed. This means that there was practically no human intervention in breeding, which is why dogs are distinguished by enviable health."
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Samoyed dog").FirstOrDefault().Id,
                    Info = "The Arctic Spitz is an animal accustomed to living in a pack and obeying its laws. This must be taken into account when building a relationship with a pet."
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Samoyed dog").FirstOrDefault().Id,
                    Info = "The Samoyed dog is distinguished by a docile character, mobility, courage, and a friendly attitude towards people and other animals."
                },

                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Cavalier K Spaniel").FirstOrDefault().Id,
                    Info = "Avarege price of Cavalier King Charles Spaniel = " + context.DogInfos.Where(x=> x.Breed == "Cavalier K Spaniel").FirstOrDefault().Price,
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Cavalier K Spaniel").FirstOrDefault().Id,
                    Info = "Cavalier King Charles Spaniels are virtually immune to mood swings. Affectionate and lively, they are on a positive wave 24 hours a day."
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Cavalier K Spaniel").FirstOrDefault().Id,
                    Info = "Representatives of this breed are typical extroverts, seeing in everyone they meet as a future friend, whom they are happy to entrust with any secrets."
                },
                new Thesis(){
                    DogInfoId = context.DogInfos.Where(x=> x.Breed == "Cavalier K Spaniel").FirstOrDefault().Id,
                    Info = "Cavalier King Charles Spaniels get along easily with cats. But the representatives of the purring fraternity are not always ready to put up with the presence of these annoying handsome men on their territory."
                }
            };

            await context.Set<Thesis>().AddRangeAsync(thesis);
        }
    }
}
