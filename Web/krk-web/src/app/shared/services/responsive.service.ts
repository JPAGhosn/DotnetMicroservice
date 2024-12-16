// src/app/services/responsive.service.ts

import {computed, Injectable, OnDestroy, signal} from '@angular/core';
import {distinctUntilChanged, fromEvent, Subscription} from 'rxjs';
import {map, startWith} from 'rxjs/operators';

type Breakpoints = {
  [key in 'mobile' | 'fold' | "ipad" | 'desktop' | "large-desktop" | "tv"]: number;
};

@Injectable({
  providedIn: 'root',
})
export class ResponsiveService implements OnDestroy {
  // Signal to hold the current screen width
  currentScreenWidth = signal<number>(window.innerWidth);

  // Breakpoint definitions in pixels
  private readonly breakpoints: Breakpoints = {
    mobile: 0, // Mobile devices
    fold: 480, // Foldable devices (e.g., foldable phones)
    ipad: 768, // iPad and similar tablets
    desktop: 1024, // Standard desktops and laptops
    'large-desktop': 1440, // Large desktops
    tv: 1920, // TV screens and large displays
  };

  // Computed signal to determine the current device
  currentDevice = computed<string>(() => {
    const width = this.currentScreenWidth();
    if (width < this.breakpoints.fold) {
      return 'mobile';
    } else if (width >= this.breakpoints.fold && width < this.breakpoints.ipad) {
      return 'fold';
    } else if (width >= this.breakpoints.ipad && width < this.breakpoints.desktop) {
      return 'ipad';
    } else if (width >= this.breakpoints.desktop && width < this.breakpoints['large-desktop']) {
      return 'desktop';
    } else if (width >= this.breakpoints['large-desktop'] && width < this.breakpoints.tv) {
      return 'large-desktop';
    } else {
      return 'tv';
    }
  });

  private resizeSubscription: Subscription;

  constructor() {
    // Listen to window resize events
    this.resizeSubscription = fromEvent(window, 'resize')
      .pipe(
        // debounceTime(30), // Debounce to prevent excessive calls
        distinctUntilChanged(),
        map((event: Event) => (event.target as Window).innerWidth),
        startWith(window.innerWidth)
      )
      .subscribe((width: number) => {
        this.currentScreenWidth.set(width);
      });
  }

  ngOnDestroy(): void {
    // Clean up the subscription when the service is destroyed
    if (this.resizeSubscription) {
      this.resizeSubscription.unsubscribe();
    }
  }

  /**
   * Retrieves the breakpoint value for a given point.
   * @param point The breakpoint name.
   * @returns The breakpoint value in pixels.
   */
  getBreakpoint(point: keyof Breakpoints): number {
    return this.breakpoints[point];
  }

  /**
   * Checks if the current screen width is at least the specified breakpoint.
   * Equivalent to the SCSS `min-width` mixin.
   * @param point The breakpoint name.
   * @returns True if current width >= breakpoint, else false.
   */
  minWidth(point: keyof Breakpoints): boolean {
    return this.currentScreenWidth() >= this.getBreakpoint(point);
  }

  /**
   * Checks if the current screen width is at most the specified breakpoint.
   * Equivalent to the SCSS `max-width` mixin.
   * @param point The breakpoint name.
   * @returns True if current width <= breakpoint, else false.
   */
  maxWidth(point: keyof Breakpoints): boolean {
    return this.currentScreenWidth() <= this.getBreakpoint(point);
  }

  /**
   * Checks if the current screen width is between the specified min and max breakpoints.
   * Equivalent to the SCSS `between` mixin.
   * @param min The minimum breakpoint name.
   * @param max The maximum breakpoint name.
   * @returns True if min <= current width < max, else false.
   */
  between(min: keyof Breakpoints, max: keyof Breakpoints): boolean {
    const minWidth = this.getBreakpoint(min);
    const maxWidth = this.getBreakpoint(max) - 1;
    const width = this.currentScreenWidth();
    return width >= minWidth && width <= maxWidth;
  }

  /**
   * Device-specific checks analogous to SCSS mixins.
   */

  isMobile(): boolean {
    return this.maxWidth('fold');
  }

  isFold(): boolean {
    return this.between('fold', 'ipad');
  }

  isIpad(): boolean {
    return this.between('ipad', 'desktop');
  }

  isDesktop(): boolean {
    return this.between('desktop', 'large-desktop');
  }

  isLargeDesktop(): boolean {
    return this.between('large-desktop', 'tv');
  }

  isTV(): boolean {
    return this.minWidth('tv');
  }
}
