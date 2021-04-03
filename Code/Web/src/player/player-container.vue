<template>
  <v-container>
    <v-row class="text-center">
      <v-col cols="12">
        <v-img
          :src="require('../assets/witches-hat.png')"
          class="my-3"
          contain
          height="200"
        />
      </v-col>

      <v-col class="mb-4">
        <h1 class="display-2 font-weight-bold mb-3">Player</h1>
      </v-col>
    </v-row>
    <v-row>
      <p>{{ user.sub }}</p>
      <p>{{ user.names }}</p>
      <p>{{ user.nickname }}</p>
      <p>{{ user.picture }}</p>
      <p>{{ user.updatedAt }}</p>
      <p>{{ user.email }}</p>
      <p>{{ user.emailVerified }}</p>
      <p>{{ user.provider }}</p>
      <p>{{ user.id }}</p>
      <p>{{ user.givenName }}</p>
      <p>{{ user.familyName }}</p>
      <p>{{ user.locale }}</p>
    </v-row>
    <v-row>
       <p>{{ player.playerId }}</p>
       <p>{{ player.sub }}</p>
       <p>{{ player.nickname }}</p>
    </v-row>
    
    <v-row>
      <CharacterList />
    </v-row>
  </v-container>
</template>

<script lang="ts">
import { Vue, Component } from "vue-property-decorator";
import CharacterList from "../character/character-list.vue";
import { getInstance } from "../auth";
import { VueAuth } from "@/auth/VueAuth";
import { User } from "../auth/User";
import { Player } from "@/player/Player";
import { PlayerProvider } from "@/player/PlayerProvider";

@Component({ components: { CharacterList } })
export default class PlayerContainer extends Vue {
  user: User = new User(undefined);
  player: Player = new Player("","","");

  async created(): Promise<void> {
    const authService: VueAuth = getInstance();
    this.user = await authService.getUser();
    const playerProvider = new PlayerProvider();
    this.player = await playerProvider.fetchFromSub(this.user.sub); 
  }
}
</script>
