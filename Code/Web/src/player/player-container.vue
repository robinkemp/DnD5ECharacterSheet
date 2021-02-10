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
      <CharacterList />
    </v-row>
    </v-container>
</template>

<script lang="ts">
import { Vue, Component } from "vue-property-decorator";
import CharacterList from "./character-list.vue";

@Component({ components: { CharacterList } })
export default class PlayerContainer extends Vue {}
</script>