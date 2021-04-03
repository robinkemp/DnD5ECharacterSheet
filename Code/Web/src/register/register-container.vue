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
        <h1 class="display-2 font-weight-bold mb-3">Register</h1>
      </v-col>
    </v-row>
    <v-row>
      <v-text-field
            label="Nickname"
            v-model="user.nickname"
          ></v-text-field>
    </v-row>
    <v-row>
       <v-btn 
        @click="registerPlayer"
        class="ma-2" 
        tile color="indigo" 
        dark>Register</v-btn>
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
import router from "@/router";

@Component({ components: { CharacterList } })
export default class RegisterContainer extends Vue {
  user: User = new User(undefined);
  player: Player = new Player("","","");
  playerProvider: PlayerProvider = new PlayerProvider();

  async created(): Promise<void> {
    const authService: VueAuth = getInstance();
    if(authService.isAuthenticated)
    {
      this.user = await authService.getUser();
      
      this.player = await this.playerProvider.fetchFromSub(this.user.sub); 
    } else {
      router.push({path: "Home"});
    }
  }
  
  async registerPlayer(): Promise<void> {
    this.player.id = "";
    this.player.sub = this.user.sub;
    this.player.nickname = this.user.nickname;
    console.log(this.player);
    const registeredPlayer = await this.playerProvider.registerPlayer(this.player);
    router.push({path: "Player"});
  }
}
</script>
