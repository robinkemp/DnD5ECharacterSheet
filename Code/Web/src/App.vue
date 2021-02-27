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
      <router-view></router-view>
    </v-main>

      <v-footer>
        <router-link to="/">Home</router-link>
        <v-spacer></v-spacer>
        <router-link to="player" v-if="$auth.isAuthenticated">Player</router-link>
        <v-spacer></v-spacer>
        <router-link to="about">About</router-link>
        <v-spacer></v-spacer>
        <router-link to="will">Spells</router-link>
      </v-footer>
  </v-app>
</template>

<script lang="ts">
import Vue from "vue";

export default Vue.extend({
  name: "App",
  components: {},
  methods: {
    login (): void {
      this.$auth.loginWithRedirect({});
    },
    logout (): void {
      this.$auth.logout({
        returnTo: window.location.origin
      })
    }
  },
  data: () => ({
    //
  })
});
</script>
