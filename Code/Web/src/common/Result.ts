export class Result<T> {
    constructor(t: T) {
        this.Value = t;
    }
    public Value: T;
    public IsSuccess: boolean = false;
  }