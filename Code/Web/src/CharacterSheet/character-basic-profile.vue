<template>
    <v-container>
    <v-row class="text-center">
      <v-col class="mb-4">
          <v-text-field label="Write here">Character Name</v-text-field>
      </v-col>
        <v-col class="mb-4">
          <v-text-field label="Write here">Class</v-text-field>
        </v-col>
        <v-col class="mb-4">
          <v-text-field label="Write here">Level</v-text-field>
        </v-col>
    </v-row>
    </v-container>
</template>
<script lang="ts">
import { Vue, Component } from "vue-property-decorator";

@Component({ components: { } })
export default class CharacterBasicProfile extends Vue {

}
</script>
<style lang="scss">

</style>