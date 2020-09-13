import { Injectable } from '@angular/core';

@Injectable()
export class ServiceBase {
  public serialize(hostContainer: any, path: string): string {
    let str = [],
      propName;
    for (propName in hostContainer) {
      if (hostContainer.hasOwnProperty(propName)) {
        const propValue: any = hostContainer[propName];

        if (propValue !== null && typeof propValue === 'object') {
          let access: string;
          if (Array.isArray(propValue)) {
            if (Array.isArray(hostContainer)) {
              access = `[${propName}]`;
            } else {
              access = propName;
            }

            const pair = this.serialize(propValue, path + access);
            str.push(pair);
          } else {
            if (Array.isArray(hostContainer)) {
              access = `[${propName}].`;
            } else {
              access = `${propName}.`;
            }

            const pair = this.serialize(propValue, path + access);
            str.push(pair);
          }
        } else {
          let access: string;
          if (Array.isArray(hostContainer)) {
            access = `[${encodeURIComponent(propName)}]`;
          } else {
            access = encodeURIComponent(propName);
          }

          if (propValue !== null) {
            const pair = `${path}${access}=${encodeURIComponent(propValue)}`;
            str.push(pair);
          }
        }
      }
    }
    return str.join('&');
  }
}
