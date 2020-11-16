import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-pokemon-component',
  templateUrl: './pokemon.component.html'
})
export class PokemonComponent {
  public pokemons: Pokemon[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Pokemon[]>(baseUrl + 'pokemon').subscribe(result => {
      this.pokemons = result;
    }, error => console.error(error));
  }
}

interface Pokemon {
  name: string;
  type1: string;
  type2: string;
}
