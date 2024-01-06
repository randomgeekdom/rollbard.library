﻿using Rollbard.Library.Rollers.Interfaces;
using System.Collections.Generic;

namespace Rollbard.Library.Rollers
{
    public class
        NounRoller : FromListRoller<string>, INounRoller
    {
        public override List<string> List => new List<string>
        {"Aardvarks ",
"Airs ",
"Airplanes ",
"Airports ",
"Alarms ",
"Alligators ",
"Alphabets ",
"Ambulances ",
"Animals ",
"Ankles ",
"Armies ",
"Answers ",
"Ants ",
"Antelopes ",
"Apples ",
"Arms ",
"Armchairs ",
"Arrows ",
"Asparaguses ",
"Babies ",
"Backs ",
"Backbones ",
"Bacons ",
"Badges ",
"Badgers ",
"Bags ",
"Bagpipes ",
"Baits ",
"Bakeries ",
"Balls ",
"Balloons ",
"Bamboos ",
"Bananas ",
"Bands ",
"Bandanas ",
"Bangles ",
"Banjos ",
"Banks ",
"Baseballs ",
"Baskets ",
"Basketballs ",
"Bats ",
"Baths ",
"Bathrooms ",
"Bathtubs ",
"Batteries ",
"Battles ",
"Bays ",
"Beaches ",
"Beads ",
"Beans ",
"Bears ",
"Beards ",
"Beasts ",
"Beats ",
"Beauties ",
"Beavers ",
"Beds ",
"Bedrooms ",
"Bees ",
"Beefs ",
"Beetles ",
"Bells ",
"Belts ",
"Benches ",
"Berets ",
"Berries ",
"Bicycles ",
"Bikes ",
"Birds ",
"Birthdays ",
"Bites ",
"Blacks ",
"Blades ",
"Blankets ",
"Blocks ",
"Bloods ",
"Blouses ",
"Blows ",
"Boards ",
"Boats ",
"Bobcats ",
"Bodies ",
"Bolts ",
"Bones ",
"Bonsais ",
"Books ",
"Bookcases ",
"Booklets ",
"Boots ",
"Borders ",
"Bottles ",
"Bottoms ",
"Boundaries ",
"Bows ",
"Bowlings ",
"Boxes ",
"Boys ",
"Brains ",
"Brakes ",
"Branches ",
"Brasses ",
"Breads ",
"Breaks ",
"Breakfasts ",
"Breaths ",
"Bricks ",
"Bridges ",
"Broccolis ",
"Brochures ",
"Brothers ",
"Brushes ",
"Bubbles ",
"Buckets ",
"Buildings ",
"Bulbs ",
"Bulls ",
"Bulldozers ",
"Bumpers ",
"Buns ",
"Buss ",
"Bushes ",
"Butters ",
"Buttons ",
"Cabbages ",
"Cacti ",
"Cafes ",
"Cakes ",
"Calculators ",
"Calendars ",
"Calves ",
"Calls ",
"Camels ",
"Cameras ",
"Camps ",
"Candles ",
"Canoes ",
"Canvass ",
"Caps ",
"Captains ",
"Cars ",
"Cards ",
"Cardboards ",
"Cardigans ",
"Carpenters ",
"Carrots ",
"Cartoons ",
"Cats ",
"Caterpillars ",
"Cathedrals ",
"Castles ",
"Cauliflowers ",
"Caves ",
"Cds ",
"Ceilings ",
"Celeries ",
"Cellos ",
"Cements ",
"Cemeteries ",
"Cereals ",
"Chains ",
"Chairs ",
"Chalks ",
"Channels ",
"Characters ",
"Cheeks ",
"Cheeses ",
"Cheetahs ",
"Cherries ",
"Chests ",
"Chests ",
"Chicks ",
"Chickens ",
"Children ",
"Chimpanzees ",
"Chins ",
"Chives ",
"Chocolates ",
"Churches ",
"Cicadas ",
"Cinemas ",
"Circles ",
"Cities ",
"Clams ",
"Clarinets ",
"Clicks ",
"Clocks ",
"Closes ",
"Closets ",
"Cloths ",
"Clouds  ",
"Coaches ",
"Coals ",
"Coasts ",
"Coats ",
"Cobwebs ",
"Cockroaches ",
"Cocoas ",
"Coffees ",
"Coils ",
"Coins ",
"Cokes ",
"Colds ",
"Collars ",
"Colleges ",
"Colts ",
"Combs ",
"Comics ",
"Commas ",
"Computers ",
"Copies ",
"Corns ",
"Costs ",
"Cottons ",
"Couches ",
"Cougars ",
"Countries ",
"Courses ",
"Courts ",
"Cousins ",
"Cows ",
"Crabs ",
"Cracks ",
"Crackers ",
"Crates ",
"Crayfishes ",
"Crayons ",
"Creams ",
"Creeks ",
"Crickets ",
"Crocodiles ",
"Crops ",
"Crows ",
"Crowds ",
"Crowns ",
"Cucumbers ",
"Cups ",
"Cupboards ",
"Curtains ",
"Curves ",
"Cushions ",
"Cyclones ",
"Dads ",
"Daffodils ",
"Daisies ",
"Dances ",
"Daughters ",
"Days ",
"Deeds ",
"Denims ",
"Dentists ",
"Deserts ",
"Desks ",
"Desserts ",
"Detectives ",
"Dews ",
"Diamonds ",
"Dictionaries ",
"Dinghies ",
"Dinosaurs ",
"Diets ",
"Dishes ",
"Dogs ",
"Dolls ",
"Dollars ",
"Doors ",
"Dragons ",
"Dragonflies ",
"Drains ",
"Drawers ",
"Dreams ",
"Dresses ",
"Dressers ",
"Drills ",
"Drinks ",
"Drums ",
"Dryers ",
"Ducks ",
"Ducklings ",
"Dungeons ",
"Dusts ",
"Eagles ",
"Ears ",
"Earths ",
"Earthquakes ",
"Eels ",
"Eggs ",
"Eggplants ",
"Elbows ",
"Elephants ",
"Energies ",
"Engines ",
"Equipment ",
"Evenings ",
"Eyes ",
"Eyebrows ",
"Faces ",
"Facts ",
"Factories ",
"Fairies",
"Families ",
"Fans ",
"Fangs ",
"Farms ",
"Fears ",
"Feasts ",
"Feathers ",
"Feet ",
"Ferryboats ",
"Fields ",
"Fights ",
"Fingers ",
"Fires ",
"Fireplaces ",
"Fishes ",
"Flags ",
"Flames ",
"Floods ",
"Floors ",
"Flowers ",
"Flutes ",
"Flies ",
"Foams ",
"Fogs ",
"Foods ",
"Foots ",
"Footballs ",
"Foreheads ",
"Forests ",
"Forks ",
"Fountains ",
"Foxes ",
"Frames ",
"Freckles ",
"Freezers ",
"Frogs ",
"Frosts ",
"Fruits ",
"Fuels ",
"Furs ",
"Furniture ",
"Games ",
"Garages ",
"Gardens ",
"Garlics ",
"Gases ",
"Gates ",
"Gears ",
"Ghosts ",
"Giraffes ",
"Girls ",
"Glasses ",
"Gloves ",
"Glues ",
"Goals ",
"Goats ",
"Gold ",
"Goldfishes ",
"Golfs ",
"Gorillas ",
"Governments ",
"Grapes ",
"Grasses ",
"Grasshoppers ",
"Greases ",
"Grills ",
"Groups ",
"Guitars ",
"Gums ",
"Gyms ",
"Gymnasts ",
"Hails ",
"Hairs ",
"Haircuts ",
"Halls ",
"Hamburgers ",
"Hammers ",
"Hamsters ",
"Hands ",
"Handballs ",
"Handles ",
"Hardware ",
"Harmonicas ",
"Harmonies ",
"Hats ",
"Hates ",
"Hawks ",
"Heads ",
"Headlights ",
"Health ",
"Hearts ",
"Heats ",
"Heavens ",
"Hedges ",
"Heights ",
"Helicopters ",
"Helmets ",
"Helps ",
"Hens ",
"Hills ",
"Hips ",
"Hippopotami",
"Histories ",
"Holes ",
"Holidays ",
"Homes ",
"Honeys ",
"Hoods ",
"Hooks ",
"Horns ",
"Horses ",
"Hoses ",
"Hospitals ",
"Hours ",
"Houses ",
"Hurricanes ",
"Hyenas ",
"Ices ",
"Icicles ",
"Ideas ",
"Inks ",
"Insects ",
"Instruments ",
"Internets ",
"Inventions ",
"Irons ",
"Islands ",
"Jackets ",
"Jaguars ",
"Jails ",
"Jams ",
"Jars ",
"Jaws ",
"Jeans ",
"Jeeps ",
"Jellies ",
"Jellyfishes ",
"Jets ",
"Jewels ",
"Jokes ",
"Journeys ",
"Judges ",
"Judos ",
"Juices ",
"Jumps ",
"Jumpers ",
"Kangaroos ",
"Karats ",
"Kayaks ",
"Kettles ",
"Keys ",
"Keyboards ",
"Kicks ",
"Kisses ",
"Kitchens ",
"Kites ",
"Kittens ",
"Knees ",
"Knifes ",
"Knights ",
"Knots ",
"Laces ",
"Ladybugs ",
"Lakes ",
"Lambs ",
"Lamps ",
"Lands ",
"Lasagnas ",
"Laughs  ",
"Leafs ",
"Leathers ",
"Leeks ",
"Legs ",
"Lemonades ",
"Leopards ",
"Letters ",
"Lettuces ",
"Libraries ",
"Lifts ",
"Lights  ",
"Lilies ",
"Lines ",
"Lions ",
"Lips ",
"Lipsticks ",
"Liquids ",
"Lists ",
"Litters ",
"Lizards ",
"Loafs ",
"Lobsters ",
"Locks ",
"Lockets ",
"Locusts ",
"Looks ",
"Lotions ",
"Loves ",
"Lunches ",
"Lynxes ",
"Macaronies ",
"Machines ",
"Magazines ",
"Magics ",
"Magicians ",
"Mails ",
"Mailboxes ",
"Mailmen ",
"Makeups ",
"Maps ",
"Marbles ",
"Marks ",
"Markets ",
"Mascaras ",
"Masks ",
"Matches ",
"Meals ",
"Meats ",
"Mechanics ",
"Medicines ",
"Memories ",
"Men ",
"Menus ",
"Messages ",
"Metals ",
"Mice ",
"Middles ",
"Milks ",
"Milkshakes ",
"Mints ",
"Minutes ",
"Mirrors ",
"Mists ",
"Mistakes ",
"Mittens ",
"Mondays ",
"Moneys ",
"Monkeys ",
"Months ",
"Moons ",
"Mornings ",
"Mosquitos ",
"Motorboats ",
"Motorcycles ",
"Mountains ",
"Mouses ",
"Moustaches ",
"Mouths ",
"Musics ",
"Mustards ",
"Nails ",
"Names ",
"Napkins ",
"Necks ",
"Needles ",
"Nests ",
"Nets ",
"News ",
"Nights ",
"Noises ",
"Noodles ",
"Noses ",
"Notes ",
"Notebooks ",
"Numbers ",
"Nuts ",
"Oaks ",
"Oatmeals ",
"Oceans ",
"Octopuses ",
"Offices ",
"Oils ",
"Olives ",
"Onions ",
"Oranges ",
"Orchestras ",
"Ostriches ",
"Otters ",
"Ovens ",
"Owls ",
"Oxen ",
"Oxygens ",
"Oysters ",
"Packets ",
"Pages ",
"Pails ",
"Pains ",
"Paints ",
"Pairs ",
"Pajamas ",
"Pamphlets ",
"Pans ",
"Pancakes ",
"Pandas ",
"Pansies ",
"Panthers ",
"Pants ",
"Papers ",
"Parcels ",
"Parents ",
"Parks ",
"Parrots ",
"Parties ",
"Pastas ",
"Pastes ",
"Pastries ",
"Patches ",
"Paths ",
"Peas ",
"Peaches ",
"Peanuts ",
"Pears ",
"Pedestrians ",
"Pelicans ",
"Pens ",
"Pencils ",
"Peppers ",
"Perfumes ",
"Persons ",
"Pests ",
"Pets ",
"Phones ",
"Pianos ",
"Pickles ",
"Pictures ",
"Pies ",
"Pigs ",
"Pigeons ",
"Pillows ",
"Pilots ",
"Pimples ",
"Pins ",
"Pipes ",
"Pizzas ",
"Planes ",
"Plants ",
"Plantations ",
"Plastics ",
"Plates ",
"Playgrounds ",
"Plots ",
"Pockets ",
"Poisons ",
"Polices ",
"Policemen ",
"Pollutions ",
"Ponds ",
"Popcorns ",
"Poppies ",
"Porcupines ",
"Postages ",
"Postboxes ",
"Pots ",
"Potatoes ",
"Poultries ",
"Powders ",
"Powers ",
"Prices ",
"Printers ",
"Prisons ",
"Pumpkins ",
"Puppies ",
"Pyramids ",
"Queens ",
"Questions ",
"Quick Sands ",
"Quills ",
"Quilts ",
"Rabbits ",
"Radios ",
"Radishes ",
"Rafts ",
"Rails ",
"Railways ",
"Rains ",
"Rainbows ",
"Raincoats ",
"Rainstorms ",
"Rakes ",
"Rats ",
"Raviolis ",
"Rays ",
"Recorders ",
"Rectangles ",
"Refrigerators ",
"Reindeers ",
"Relativess ",
"Restaurants ",
"Rewards ",
"Rhinoceroses ",
"Races ",
"Riddles ",
"Rings ",
"Rivers ",
"Roads ",
"Roasts ",
"Rocks ",
"Rolls ",
"Roofs ",
"Rooms ",
"Roosters ",
"Roses ",
"Rowboats ",
"Rubbers ",
"Sacks ",
"Sails ",
"Sailboats ",
"Sailors ",
"Salads ",
"Salmons ",
"Salts ",
"Sands ",
"Sandwiches ",
"Sardines ",
"Sauces ",
"Sausages ",
"Saws ",
"Saxophones ",
"Scarecrows ",
"Scarfs ",
"Schools ",
"Scissors ",
"Scooters ",
"Scorpions ",
"Screws ",
"Screwdrivers ",
"Seas ",
"Seagulls ",
"Seals ",
"Seaplanes ",
"Seashores ",
"Seasons ",
"Seats ",
"Seconds ",
"Seeds ",
"Sentences ",
"Servants ",
"Shades ",
"Shadows ",
"Shallots ",
"Shampoos ",
"Sharks ",
"Shears ",
"Sheep ",
"Sheets ",
"Shelves ",
"Shells ",
"Shields ",
"Ships ",
"Shirts ",
"Shoes ",
"Shoemakers ",
"Shops ",
"Shorts ",
"Shoulders ",
"Shovels ",
"Shoes ",
"Sides ",
"Sidewalks ",
"Signs ",
"Signatures ",
"Silks ",
"Silvers ",
"Singers ",
"Sinks ",
"Sisters ",
"Skins ",
"Skirts ",
"Skies ",
"Sleds ",
"Slippers ",
"Slopes ",
"Smokes ",
"Snails ",
"Snakes ",
"Sneezes ",
"Snows ",
"Snowflakes ",
"Snowmen",
"Soaps ",
"Soccer Balls ",
"Socks ",
"Sofas ",
"Softballs ",
"Soldiers ",
"Sons ",
"Songs ",
"Sounds ",
"Soups ",
"Soybeans ",
"Spaces ",
"Spades ",
"Spaghettis ",
"Sparks ",
"Sparrows ",
"Spears ",
"Speedboats ",
"Spiders ",
"Spikes ",
"Spinaches ",
"Sponges ",
"Spoons ",
"Spots ",
"Sprouts ",
"Spies ",
"Squares ",
"Squashes ",
"Squids ",
"Squirrels ",
"Stages ",
"Staircases ",
"Stamps ",
"Stars ",
"Stations ",
"Steams ",
"Steels ",
"Stems ",
"Steps ",
"Stews ",
"Sticks ",
"Stitches ",
"Stingers ",
"Stomachs ",
"Stones ",
"Stools ",
"Signs ",
"Stopwatches",
"Stores ",
"Storms ",
"Stories ",
"Stoves ",
"Strangers ",
"Straws ",
"Streams ",
"Strings ",
"Submarines ",
"Sugars ",
"Suits ",
"Summers ",
"Suns ",
"Sunshines ",
"Sunflowers ",
"Supermarkets ",
"Surfboards ",
"Surnames ",
"Surprises ",
"Sushis ",
"Swallows ",
"Swamps ",
"Swans ",
"Sweaters ",
"Sweatshirts ",
"Sweets ",
"Swings ",
"Switches ",
"Swords ",
"Swordfishes ",
"Syrups ",
"Tables ",
"Tabletops ",
"Tadpoles ",
"Tails ",
"Targets ",
"Taxes ",
"Taxis ",
"Teas ",
"Teachers ",
"Teams ",
"Teeth ",
"Televisions ",
"Tents ",
"Textbooks ",
"Theaters ",
"Thistles ",
"Thoughts ",
"Threads ",
"Throats ",
"Thrones ",
"Thumbs ",
"Thunders ",
"Thunderstorms ",
"Tickets ",
"Ties ",
"Tigers ",
"Tiles ",
"Times ",
"Tires ",
"Toads ",
"Toasts ",
"Toes ",
"Toilets ",
"Tomatoes ",
"Tongues ",
"Toothbrushes ",
"Toothpastes ",
"Tops ",
"Tornados ",
"Tortoises ",
"Towers ",
"Towns ",
"Toys ",
"Tractors ",
"Traffics ",
"Trails ",
"Trains ",
"Transports ",
"Trays ",
"Trees ",
"Triangles ",
"Tricks ",
"Trips ",
"Trombones ",
"Troubles ",
"Trousers ",
"Trucks ",
"Trumpets ",
"Trunks ",
"Tubs ",
"Tubas ",
"Tugboats ",
"Tulips ",
"Tunas ",
"Tunes ",
"Turkeys ",
"Turnips ",
"Turtles ",
"Tvs ",
"Twigs ",
"Twilights ",
"Twines ",
"Umbrellas ",
"Valleys ",
"Vans ",
"Vases ",
"Vegetables ",
"Veils ",
"Veins ",
"Vessels ",
"Vests ",
"Violins ",
"Volcanoes ",
"Volleyballs ",
"Vultures ",
"Walls ",
"Wallabies ",
"Walruses ",
"Washers ",
"Wasps ",
"Wastes ",
"Watches ",
"Watchmakers ",
"Waters ",
"Waterfalls ",
"Waves ",
"Waxes ",
"Weapons ",
"Weasels ",
"Weathers ",
"Wedges ",
"Whales ",
"Wheels ",
"Whips ",
"Whistles ",
"Wildernesses ",
"Willows ",
"Winds ",
"Windows ",
"Windscreens ",
"Wings ",
"Winters ",
"Wires ",
"Wishes ",
"Witches ",
"Wolfs ",
"Women",
"Woods ",
"Wools ",
"Words ",
"Workshops ",
"Worms ",
"Wounds ",
"Wrens ",
"Wrenches ",
"Wrinkles ",
"Wrists ",
"Xylophones ",
"Yachts ",
"Yaks ",
"Yards ",
"Yogurts ",
"Zebras ",
"Zippers ",
"Zoos ",
 };
    }
}