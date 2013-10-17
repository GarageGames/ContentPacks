singleton TSShapeConstructor(PlayerAnim_Disposition_RootDAE)
{
   baseShape = "./PlayerAnim_Disposition_Root.DAE";
   neverImport = "EnvironmentAmbientLight";
   loadLights = "0";
};

function PlayerAnim_Disposition_RootDAE::onLoad(%this)
{
   %this.setSequenceCyclic("ambient", "true");
   %this.addSequence("ambient", "Root", "40", "99");
}
