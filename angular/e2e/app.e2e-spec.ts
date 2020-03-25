import { ExampleOneTemplatePage } from './app.po';

describe('ExampleOne App', function() {
  let page: ExampleOneTemplatePage;

  beforeEach(() => {
    page = new ExampleOneTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
