import { camelCase } from "lodash"

export class User {
  sub = "";
  names = "";
  nickname = "";
  picture = "";
  updatedAt = "";
  email = "";
  emailVerified = false;

  provider?: string;
  id?: string;

  givenName?: string;
  familyName?: string;
  locale?: string;
  [key: string]: string | boolean | undefined;

  constructor (auth0User: { [key: string]: string | boolean | undefined } | undefined) {
    if (!auth0User) return
    for (const key in auth0User) {
      this[camelCase(key)] = auth0User[key]
    }

    this.sub = auth0User.sub as string
    this.provider = this.sub.split('|')[0]
    this.id = this.sub.split('|')[1]
  }
}