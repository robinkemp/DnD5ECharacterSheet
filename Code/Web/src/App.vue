<template>
  <v-app>
    <v-app-bar app color="primary" dark>
        <v-img
          :src="require('./assets/EmberAces.png')"
          contain
          height="75"
        />
       
    <div v-if="!$auth.loading">
      <!-- show login when not authenticated -->
      <button v-if="!$auth.isAuthenticated" @click="login">Log in</button>
      <!-- show logout when authenticated -->
      <button v-if="$auth.isAuthenticated" @click="logout">Log out</button>
    </div>

    </v-app-bar>

    <v-main>
      <NavContainer 
        :authenticated="this.authService.isAuthenticated" 
        :player="this.player">
      </NavContainer>
      <router-view></router-view>
    </v-main>

      <v-footer>
        
      </v-footer>
  </v-app>
</template>

<script lang="ts">
import { Vue, Component } from "vue-property-decorator";
import NavContainer from "./navigation/nav-container.vue";
import { User } from "./auth/User";
import { Player } from "@/player/Player";
import { PlayerProvider } from "@/player/PlayerProvider";
import { getInstance } from "./auth";
import { VueAuth } from "@/auth/VueAuth";

@Component({ components: { NavContainer } })
export default class App extends Vue {
  authService: VueAuth = getInstance();
  user: User = new User(undefined);
  player: Player = new Player("","","");
  playerProvider: PlayerProvider = new PlayerProvider();

   async created(): Promise<void> {
      this.authService.$watch("loading", async(isLoading) => {
        if (isLoading === false && this.authService.isAuthenticated) {
          this.user = await this.authService.getUser();
          this.player = await this.playerProvider.fetchFromSub(this.user.sub); 
        }
      });
  }

  login (): void {
      this.$auth.loginWithRedirect({});
    }

  logout (): void {
    this.$auth.logout({
      returnTo: window.location.origin
    });
  }
}
</script>
