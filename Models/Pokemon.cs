using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AngelApp.Models
{
    #nullable enable
	public class Pokemon
	{
		public string? abilities { get; set; }
		public decimal? against_bug { get; set; }
		public decimal? against_dark { get; set; }
		public decimal? against_dragon { get; set; }
		public decimal? against_electric { get; set; }
		public decimal? against_fairy { get; set; }
		public decimal? against_fight { get; set; }
		public decimal? against_fire { get; set; }
		public decimal? against_flying { get; set; }
		public decimal? against_ghost { get; set; }
		public decimal? against_grass { get; set; }
		public decimal? against_ground { get; set; }
		public decimal? against_ice { get; set; }
		public decimal? against_normal { get; set; }
		public decimal? against_poison { get; set; }
		public decimal? against_psychic { get; set; }
		public decimal? against_rock { get; set; }
		public decimal? against_steel { get; set; }
		public decimal? against_water { get; set; }
		public int? attack { get; set; }
		public int? base_egg_steps { get; set; }
		public int? base_happiness { get; set; }
		public int? base_total { get; set; }
		public string? capture_rate { get; set; }
		public string? classfication { get; set; }
		public int? defense { get; set; }
		public int? experience_growth { get; set; }
        public decimal? height_m { get; set; }
		public int? hp { get; set; }
		public string? japanese_name { get; set; }
		public string name { get; set; }
		public decimal? percentage_male { get; set; }
		[Key]
		public int pokedex_number { get; set; }
		public int? sp_attack { get; set; }
		public int? sp_defense { get; set; }
		public int? speed { get; set; }
		public string? type1 { get; set; }
		public string? type2 { get; set; }
		public decimal? weight_kg { get; set; }
		public int? generation { get; set; }
		public int? is_legendary { get; set; }

        #nullable enable
		public Pokemon(){}

        public Pokemon(string abilities_, decimal against_bug_, decimal against_dark_, decimal against_dragon_, decimal against_electric_, decimal against_fairy_, decimal against_fight_, decimal against_fire_, decimal against_flying_, decimal against_ghost_, decimal against_grass_, decimal against_ground_, decimal against_ice_, decimal against_normal_, decimal against_poison_, decimal against_psychic_, decimal against_rock_, decimal against_steel_, decimal against_water_, int attack_, int base_egg_steps_, int base_happiness_, int base_total_, string capture_rate_, string classfication_, int defense_, int experience_growth_, decimal height_m_, int hp_, string japanese_name_, string name_, decimal percentage_male_, int pokedex_number_, int sp_attack_, int sp_defense_, int speed_, string type1_, string type2_, decimal weight_kg_, int generation_, int is_legendary_)
		{
			this.abilities = abilities_;
			this.against_bug = against_bug_;
			this.against_dark = against_dark_;
			this.against_dragon = against_dragon_;
			this.against_electric = against_electric_;
			this.against_fairy = against_fairy_;
			this.against_fight = against_fight_;
			this.against_fire = against_fire_;
			this.against_flying = against_flying_;
			this.against_ghost = against_ghost_;
			this.against_grass = against_grass_;
			this.against_ground = against_ground_;
			this.against_ice = against_ice_;
			this.against_normal = against_normal_;
			this.against_poison = against_poison_;
			this.against_psychic = against_psychic_;
			this.against_rock = against_rock_;
			this.against_steel = against_steel_;
			this.against_water = against_water_;
			this.attack = attack_;
			this.base_egg_steps = base_egg_steps_;
			this.base_happiness = base_happiness_;
			this.base_total = base_total_;
			this.capture_rate = capture_rate_;
			this.classfication = classfication_;
			this.defense = defense_;
			this.experience_growth = experience_growth_;
			this.height_m = height_m_;
			this.hp = hp_;
			this.japanese_name = japanese_name_;
			this.name = name_;
			this.percentage_male = percentage_male_;
			this.pokedex_number = pokedex_number_;
			this.sp_attack = sp_attack_;
			this.sp_defense = sp_defense_;
			this.speed = speed_;
			this.type1 = type1_;
			this.type2 = type2_;
			this.weight_kg = weight_kg_;
			this.generation = generation_;
			this.is_legendary = is_legendary_;
		}
	}
}
