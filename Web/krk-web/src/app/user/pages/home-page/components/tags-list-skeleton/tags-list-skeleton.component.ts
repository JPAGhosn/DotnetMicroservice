import {Component} from '@angular/core';

@Component({
  selector: 'krk-tags-list-skeleton',
  standalone: true,
  imports: [],
  templateUrl: './tags-list-skeleton.component.html',
  styleUrl: './tags-list-skeleton.component.scss'
})
export class TagsListSkeletonComponent {
  skeletonArray = Array(6 * 10).fill(0).map((_, i) => i + 1);
}
